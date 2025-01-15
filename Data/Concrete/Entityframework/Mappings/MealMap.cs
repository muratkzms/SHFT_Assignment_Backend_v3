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
    public class MealMap : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(X => X.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(500);
            builder.Property(x => x.MealTime).IsRequired();


            builder.Property(x => x.CreatedByName).IsRequired();
            builder.Property(x => x.CreatedByName).HasMaxLength(50);
            builder.Property(x => x.ModifiedByName).IsRequired();
            builder.Property(x => x.ModifiedByName).HasMaxLength(50);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne<DietPlan>(x => x.DietPlan).WithMany(d => d.Meals).HasForeignKey(x => x.DietPlanId);
            builder.ToTable("Meals");

            builder.HasData(
                new Meal
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",

                    Name = "Ketojenik Sabah Kahvaltısı",
                    MealTime = new TimeOnly(09, 30),
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.",
                    DietPlanId = 1,
                },
                new Meal
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",

                    Name = "Ketojenik Öğlen yemeği",
                    MealTime = new TimeOnly(09, 30),
                    Content = "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler.",
                    DietPlanId = 1,
                },
                new Meal
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",

                    Name = "Ketojenik Akşam yemeği",
                    MealTime = new TimeOnly(09, 30),
                    Content = "Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar.",
                    DietPlanId = 1,
                }
                );
        }
    }
}
