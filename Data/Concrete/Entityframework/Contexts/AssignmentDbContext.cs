using Data.Concrete.Entityframework.Mappings;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Entityframework.Contexts
{
    public class AssignmentDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Meal> Meals { get; set; }

        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasMany(c => c.DietPlans)
                .WithOne(d => d.Client)
                .HasForeignKey(d => d.ClientId);

            builder.Entity<DietPlan>()
                .HasMany(c => c.Meals)
                .WithOne(d => d.DietPlan)
                .HasForeignKey(d => d.DietPlanId);

            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ClientMap());
            builder.ApplyConfiguration(new DietPlanMap());
            builder.ApplyConfiguration(new MealMap());

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserTokenMap());
        }
    }
}
