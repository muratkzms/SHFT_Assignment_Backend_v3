using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.Entityframework.Mappings
{
    public class DietPlanMap : IEntityTypeConfiguration<DietPlan>
    {
        public void Configure(EntityTypeBuilder<DietPlan> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Title).HasMaxLength(70);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.StartAt).IsRequired();
            builder.Property(c => c.EndAt).IsRequired();
            builder.Property(c => c.StartingWeight).IsRequired();

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();

            builder.HasData(
                new DietPlan
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",

                    Title = "Ketojenik Diet Planı 1",
                    Description = "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır.",
                    StartAt = DateTime.Now,
                    EndAt = DateTime.Now.AddMonths(3),
                    StartingWeight = (float)74.7,
                    ClientId = 1,
                }
                );
        }
    }
}
