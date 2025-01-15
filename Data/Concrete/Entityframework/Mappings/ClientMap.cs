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
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Fullname).IsRequired();
            builder.Property(c => c.Fullname).HasMaxLength(70);
            builder.Property(c => c.About).HasMaxLength(500);

            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();

            builder.HasData(
                new Client
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    CreatedByName = "InitialCreate",
                    ModifiedByName = "InitialCreate",

                    Picture = @"https://cdn.prod.website-files.com/6365d860c7b7a7191055eb8a/65a753c71ddf78d3cc7ae17d_Zaid%20Schwartz-p-500.png",
                    About = "Elektronik Mühendisi",
                    Fullname = "Ali Karakuş",
                    Weight = 79,
                    Height = 177,
                    DateOfBirth = DateTime.Now.AddYears(-38)
                }
                );
        }
    }
}
