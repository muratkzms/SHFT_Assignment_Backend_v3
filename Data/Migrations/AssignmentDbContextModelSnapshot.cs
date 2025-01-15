﻿// <auto-generated />
using System;
using Data.Concrete.Entityframework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AssignmentDbContext))]
    partial class AssignmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Default Client Of DietPlan",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2025, 1, 11, 14, 25, 58, 828, DateTimeKind.Local).AddTicks(9371),
                            DateOfBirth = new DateTime(1987, 1, 11, 14, 25, 58, 829, DateTimeKind.Local).AddTicks(2324),
                            Fullname = "Zeynep Karakuş",
                            Height = 160,
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2025, 1, 11, 14, 25, 58, 828, DateTimeKind.Local).AddTicks(9725),
                            Picture = "/UserImages/defaultuser.png",
                            Weight = 69
                        });
                });

            modelBuilder.Entity("Entities.Concrete.DietPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("StartingWeight")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("DietPlans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(6839),
                            Description = "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır.",
                            EndAt = new DateTime(2025, 4, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(7625),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(6840),
                            StartAt = new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(7372),
                            StartingWeight = 74.7f,
                            Title = "Ketojenik Diet Planı 1"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DietPlanId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<TimeOnly>("MealTime")
                        .HasColumnType("time");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId");

                    b.ToTable("Meals", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(634),
                            DietPlanId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            MealTime = new TimeOnly(9, 30, 0),
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(635),
                            Name = "Ketojenik Sabah Kahvaltısı"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1708),
                            DietPlanId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            MealTime = new TimeOnly(9, 30, 0),
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1709),
                            Name = "Ketojenik Öğlen yemeği"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1712),
                            DietPlanId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            MealTime = new TimeOnly(9, 30, 0),
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1713),
                            Name = "Ketojenik Akşam yemeği"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "a2bfb850-e374-4416-8b18-d0bbeb15bfbd",
                            Name = "Category.Create",
                            NormalizedName = "CATEGORY.CREATE"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "22c7bd3f-7538-4b40-9dea-3e2ece9222bc",
                            Name = "Category.Read",
                            NormalizedName = "CATEGORY.READ"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "7d98c03e-a044-421d-b3e0-f597a78d57dd",
                            Name = "Category.Update",
                            NormalizedName = "CATEGORY.UPDATE"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "1301874f-6f1a-4c25-9b23-608b67e148c0",
                            Name = "Category.Delete",
                            NormalizedName = "CATEGORY.DELETE"
                        },
                        new
                        {
                            Id = 5,
                            ConcurrencyStamp = "d8d26f2b-2425-4cc9-a3ac-576b5a302aaf",
                            Name = "Article.Create",
                            NormalizedName = "ARTICLE.CREATE"
                        },
                        new
                        {
                            Id = 6,
                            ConcurrencyStamp = "24db7693-7a7f-4d85-a593-bd6de80c1e8e",
                            Name = "Article.Read",
                            NormalizedName = "ARTICLE.READ"
                        },
                        new
                        {
                            Id = 7,
                            ConcurrencyStamp = "5a077236-bd27-45bb-ab44-6cbbecddb920",
                            Name = "Article.Update",
                            NormalizedName = "ARTICLE.UPDATE"
                        },
                        new
                        {
                            Id = 8,
                            ConcurrencyStamp = "e0a4d60d-977e-442e-9e1f-0728fe4dc296",
                            Name = "Article.Delete",
                            NormalizedName = "ARTICLE.DELETE"
                        },
                        new
                        {
                            Id = 9,
                            ConcurrencyStamp = "c75ed801-ee51-4f06-8e02-baee55a697b9",
                            Name = "User.Create",
                            NormalizedName = "USER.CREATE"
                        },
                        new
                        {
                            Id = 10,
                            ConcurrencyStamp = "e4c9d151-2292-478a-91f5-a201bf0a0b7f",
                            Name = "User.Read",
                            NormalizedName = "USER.READ"
                        },
                        new
                        {
                            Id = 11,
                            ConcurrencyStamp = "24e90f21-559e-4346-ba95-df5aa611e951",
                            Name = "User.Update",
                            NormalizedName = "USER.UPDATE"
                        },
                        new
                        {
                            Id = 12,
                            ConcurrencyStamp = "0afe7bee-8853-4cf9-aea3-d075dd8275d6",
                            Name = "User.Delete",
                            NormalizedName = "USER.DELETE"
                        },
                        new
                        {
                            Id = 13,
                            ConcurrencyStamp = "665c06eb-44c6-447c-a065-622c15090675",
                            Name = "Role.Create",
                            NormalizedName = "ROLE.CREATE"
                        },
                        new
                        {
                            Id = 14,
                            ConcurrencyStamp = "493bf4e6-8667-45a8-84f2-79bfcd94a3e5",
                            Name = "Role.Read",
                            NormalizedName = "ROLE.READ"
                        },
                        new
                        {
                            Id = 15,
                            ConcurrencyStamp = "4eaa45ac-881a-4c0d-889e-3b7ad96387e3",
                            Name = "Role.Update",
                            NormalizedName = "ROLE.UPDATE"
                        },
                        new
                        {
                            Id = 16,
                            ConcurrencyStamp = "435bdd8e-d80b-4ccd-b0f6-01e2d7723caf",
                            Name = "Role.Delete",
                            NormalizedName = "ROLE.DELETE"
                        },
                        new
                        {
                            Id = 17,
                            ConcurrencyStamp = "704bda9c-f30d-4650-9478-eaaa59aede12",
                            Name = "Comment.Create",
                            NormalizedName = "COMMENT.CREATE"
                        },
                        new
                        {
                            Id = 18,
                            ConcurrencyStamp = "1718608a-2aaa-437b-8aa0-4259ae2e107f",
                            Name = "Comment.Read",
                            NormalizedName = "COMMENT.READ"
                        },
                        new
                        {
                            Id = 19,
                            ConcurrencyStamp = "db28036e-e840-437f-ab4b-b3a659d0a5cf",
                            Name = "Comment.Update",
                            NormalizedName = "COMMENT.UPDATE"
                        },
                        new
                        {
                            Id = 20,
                            ConcurrencyStamp = "3ed0a92c-aea4-43ef-ba08-6e69db22037b",
                            Name = "Comment.Delete",
                            NormalizedName = "COMMENT.DELETE"
                        },
                        new
                        {
                            Id = 21,
                            ConcurrencyStamp = "39ec8934-b2d3-4201-aa55-fd9a29638a0b",
                            Name = "AdminArea.Home.Read",
                            NormalizedName = "ADMINAREA.HOME.READ"
                        },
                        new
                        {
                            Id = 22,
                            ConcurrencyStamp = "8aedd225-e182-4df2-8846-0a55d9d583bf",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Admin User of DietPlanSystem",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aaa2fb67-4d7e-4a0b-a63a-52c3f49eb481",
                            Email = "adminuser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINUSER@GMAIL.COM",
                            NormalizedUserName = "ADMINUSER",
                            PasswordHash = "AQAAAAIAAYagAAAAEEbuA1UR99fez4bkNPsQ3twO5x6VDtqMJHKAyY5xC/1/E1uevISczMg8L1j1e0QT0w==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultuser.png",
                            SecurityStamp = "099f6c4e-4171-45d9-a07b-a0765f2c54e7",
                            TwoFactorEnabled = false,
                            UserName = "adminuser"
                        },
                        new
                        {
                            Id = 2,
                            About = "dietician User of DietPlanSystem",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "87fd7e68-aa27-4c7b-8d71-c65d52fdc852",
                            Email = "dieticianuser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "DIETICIANUSER@GMAIL.COM",
                            NormalizedUserName = "DIETICIANUSER",
                            PasswordHash = "AQAAAAIAAYagAAAAEPAoa0suYhnVBr3cRy/q07DA8E/Nnv++OAR9j9rvyo2Ar4rHzU1Hhvviq2oGhk0erg==",
                            PhoneNumber = "+905555555555",
                            PhoneNumberConfirmed = true,
                            Picture = "/userImages/defaultuser.png",
                            SecurityStamp = "95afc87c-eaec-49ec-924a-6d37daa336dc",
                            TwoFactorEnabled = false,
                            UserName = "dieticianuser"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 5
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 6
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 7
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 8
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 9
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 10
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 11
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 12
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 13
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 14
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 15
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 16
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 17
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 18
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 19
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 20
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 21
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 22
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 5
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 6
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 7
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 8
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 17
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 18
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 19
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 20
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 21
                        });
                });

            modelBuilder.Entity("Entities.Concrete.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Concrete.DietPlan", b =>
                {
                    b.HasOne("Entities.Concrete.Client", "Client")
                        .WithMany("DietPlans")
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Entities.Concrete.Meal", b =>
                {
                    b.HasOne("Entities.Concrete.DietPlan", "DietPlan")
                        .WithMany("Meals")
                        .HasForeignKey("DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");
                });

            modelBuilder.Entity("Entities.Concrete.RoleClaim", b =>
                {
                    b.HasOne("Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.UserClaim", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.UserLogin", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.UserRole", b =>
                {
                    b.HasOne("Entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.UserToken", b =>
                {
                    b.HasOne("Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Client", b =>
                {
                    b.Navigation("DietPlans");
                });

            modelBuilder.Entity("Entities.Concrete.DietPlan", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
