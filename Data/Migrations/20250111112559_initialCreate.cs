using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    About = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartingWeight = table.Column<float>(type: "real", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietPlans_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MealTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    DietPlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "About", "CreatedByName", "CreatedDate", "DateOfBirth", "Fullname", "Height", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Picture", "Weight" },
                values: new object[] { 1, "Default Client Of DietPlan", "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 828, DateTimeKind.Local).AddTicks(9371), new DateTime(1987, 1, 11, 14, 25, 58, 829, DateTimeKind.Local).AddTicks(2324), "Zeynep Karakuş", 160, true, false, "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 828, DateTimeKind.Local).AddTicks(9725), "/UserImages/defaultuser.png", 69 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "a2bfb850-e374-4416-8b18-d0bbeb15bfbd", "Category.Create", "CATEGORY.CREATE" },
                    { 2, "22c7bd3f-7538-4b40-9dea-3e2ece9222bc", "Category.Read", "CATEGORY.READ" },
                    { 3, "7d98c03e-a044-421d-b3e0-f597a78d57dd", "Category.Update", "CATEGORY.UPDATE" },
                    { 4, "1301874f-6f1a-4c25-9b23-608b67e148c0", "Category.Delete", "CATEGORY.DELETE" },
                    { 5, "d8d26f2b-2425-4cc9-a3ac-576b5a302aaf", "Article.Create", "ARTICLE.CREATE" },
                    { 6, "24db7693-7a7f-4d85-a593-bd6de80c1e8e", "Article.Read", "ARTICLE.READ" },
                    { 7, "5a077236-bd27-45bb-ab44-6cbbecddb920", "Article.Update", "ARTICLE.UPDATE" },
                    { 8, "e0a4d60d-977e-442e-9e1f-0728fe4dc296", "Article.Delete", "ARTICLE.DELETE" },
                    { 9, "c75ed801-ee51-4f06-8e02-baee55a697b9", "User.Create", "USER.CREATE" },
                    { 10, "e4c9d151-2292-478a-91f5-a201bf0a0b7f", "User.Read", "USER.READ" },
                    { 11, "24e90f21-559e-4346-ba95-df5aa611e951", "User.Update", "USER.UPDATE" },
                    { 12, "0afe7bee-8853-4cf9-aea3-d075dd8275d6", "User.Delete", "USER.DELETE" },
                    { 13, "665c06eb-44c6-447c-a065-622c15090675", "Role.Create", "ROLE.CREATE" },
                    { 14, "493bf4e6-8667-45a8-84f2-79bfcd94a3e5", "Role.Read", "ROLE.READ" },
                    { 15, "4eaa45ac-881a-4c0d-889e-3b7ad96387e3", "Role.Update", "ROLE.UPDATE" },
                    { 16, "435bdd8e-d80b-4ccd-b0f6-01e2d7723caf", "Role.Delete", "ROLE.DELETE" },
                    { 17, "704bda9c-f30d-4650-9478-eaaa59aede12", "Comment.Create", "COMMENT.CREATE" },
                    { 18, "1718608a-2aaa-437b-8aa0-4259ae2e107f", "Comment.Read", "COMMENT.READ" },
                    { 19, "db28036e-e840-437f-ab4b-b3a659d0a5cf", "Comment.Update", "COMMENT.UPDATE" },
                    { 20, "3ed0a92c-aea4-43ef-ba08-6e69db22037b", "Comment.Delete", "COMMENT.DELETE" },
                    { 21, "39ec8934-b2d3-4201-aa55-fd9a29638a0b", "AdminArea.Home.Read", "ADMINAREA.HOME.READ" },
                    { 22, "8aedd225-e182-4df2-8846-0a55d9d583bf", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, "Admin User of DietPlanSystem", 0, "aaa2fb67-4d7e-4a0b-a63a-52c3f49eb481", "adminuser@gmail.com", true, "Admin", "User", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAEEbuA1UR99fez4bkNPsQ3twO5x6VDtqMJHKAyY5xC/1/E1uevISczMg8L1j1e0QT0w==", "+905555555555", true, "/userImages/defaultuser.png", "099f6c4e-4171-45d9-a07b-a0765f2c54e7", false, "adminuser" },
                    { 2, "dietician User of DietPlanSystem", 0, "87fd7e68-aa27-4c7b-8d71-c65d52fdc852", "dieticianuser@gmail.com", true, "Admin", "User", false, null, "DIETICIANUSER@GMAIL.COM", "DIETICIANUSER", "AQAAAAIAAYagAAAAEPAoa0suYhnVBr3cRy/q07DA8E/Nnv++OAR9j9rvyo2Ar4rHzU1Hhvviq2oGhk0erg==", "+905555555555", true, "/userImages/defaultuser.png", "95afc87c-eaec-49ec-924a-6d37daa336dc", false, "dieticianuser" }
                });

            migrationBuilder.InsertData(
                table: "DietPlans",
                columns: new[] { "Id", "ClientId", "CreatedByName", "CreatedDate", "Description", "EndAt", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "StartAt", "StartingWeight", "Title" },
                values: new object[] { 1, 1, "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(6839), "Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır.", new DateTime(2025, 4, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(7625), true, false, "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 1, 11, 14, 25, 58, 831, DateTimeKind.Local).AddTicks(7372), 74.7f, "Ketojenik Diet Planı 1" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedDate", "DietPlanId", "IsActive", "IsDeleted", "MealTime", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir.", "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(634), 1, true, false, new TimeOnly(9, 30, 0), "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(635), "Ketojenik Sabah Kahvaltısı" },
                    { 2, "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler.", "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1708), 1, true, false, new TimeOnly(9, 30, 0), "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1709), "Ketojenik Öğlen yemeği" },
                    { 3, "Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar.", "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1712), 1, true, false, new TimeOnly(9, 30, 0), "InitialCreate", new DateTime(2025, 1, 11, 14, 25, 58, 835, DateTimeKind.Local).AddTicks(1713), "Ketojenik Akşam yemeği" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DietPlans_ClientId",
                table: "DietPlans",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DietPlanId",
                table: "Meals",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "DietPlans");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
