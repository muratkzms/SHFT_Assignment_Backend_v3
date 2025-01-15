using Data.Abstract;
using Data.Concrete;
using Data.Concrete.Entityframework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstract;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AssignmentDbContext>(opt => opt.UseSqlServer(connectionString));
            services.AddDbContext<AssignmentDbContext>(options =>
            {
                options.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored));
                options.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
            });

            services.AddIdentity<User, Role>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 5;
                opt.Password.RequiredUniqueChars = 2;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;

                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opt.User.RequireUniqueEmail = true;
            }
                ).AddEntityFrameworkStores<AssignmentDbContext>();
            services.Configure<SecurityStampValidatorOptions>(opt =>
            {
                //opt.ValidationInterval = TimeSpan.Zero;
                opt.ValidationInterval = TimeSpan.FromMinutes(5);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClientService, ClientManager>();
            services.AddScoped<IDietplanService, DietplanManager>();
            services.AddScoped<IMealService, MealManager>();

            return services;
        }
    }
}
