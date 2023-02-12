using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("15eb8257-86f4-46b7-b354-dde58cd0acac"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("eff50466-9910-4446-8120-5ced4d6acb0b"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5971527-6b0c-48a7-bdb3-2abad65b44b4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("43051bc4-ffd0-42af-aa75-8d49ddeb64f9"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a25b44c-be6d-4a9a-8c79-9e415c75684a"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1cd1187-d207-4da4-8bc4-79c2086f6f18"));

            migrationBuilder.AddColumn<int>(
                name: "PopularityScore",
                table: "ShopProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "views",
                table: "ShopProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("51801363-562f-4823-90cb-730629e42f27"), "9040f2a5-a4dc-4cc1-a6f5-79efc869b64d", null, "Staff", null },
                    { new Guid("a8036489-fd50-4d4a-b421-51a3e18eb870"), "28004e2f-1854-4fd9-8c0c-3bca0524e065", null, "Admin", null },
                    { new Guid("d36f33f6-70da-4b1a-90ab-589db8eba412"), "b8b30eae-4a97-4712-b102-64603f932365", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "CitizenIdentityCard", "CitizenIdentityCardBackImage", "CitizenIdentityCardFrontImage", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCardImage", "StudentNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4254958c-484d-40ee-a211-94c4a44bd7f6"), 0, null, null, null, "45c3c446-0fa2-45ff-b588-1508fe8cd3b7", "staff@gmail.com", false, "System", "Staff", false, null, null, null, "AQAAAAEAACcQAAAAEM94hKxiyuRSefV/6iMf9NJFgGmxoKNJFA3/uT+hyytiuGnmdmOh2cpT0q/Z+5kJFQ==", null, false, null, null, null, false, "staff@gmail.com" },
                    { new Guid("a3705bd2-3d43-4a26-97ce-70a878745500"), 0, null, null, null, "37be4321-83d6-40e4-80e6-c5edae40cbea", "admin@gmail.com", false, "System", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEECGg4+O3J5ghQXuYtUHdeF2KosWr7LjE+ycOCQJ+jwhFdgSfQ60K5rmahEOUr0cUA==", null, false, null, null, null, false, "admin@gmail.com" },
                    { new Guid("db49d705-5a8a-43f6-8a2a-5b68f0fd1e8b"), 0, null, null, null, "cc70af25-e959-4db2-95ef-6f5f8c0e40a4", "Customer@gmail.com", false, "System", "Customer", false, null, null, null, "AQAAAAEAACcQAAAAEJQMb+9H1yl2Zn6hNiIypLJJLGMhZoDw7rxWCe2SJ4IIMJMfVyaCGT477X79txLd9g==", null, false, null, null, null, false, "Customer@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("51801363-562f-4823-90cb-730629e42f27"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a8036489-fd50-4d4a-b421-51a3e18eb870"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d36f33f6-70da-4b1a-90ab-589db8eba412"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("4254958c-484d-40ee-a211-94c4a44bd7f6"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a3705bd2-3d43-4a26-97ce-70a878745500"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("db49d705-5a8a-43f6-8a2a-5b68f0fd1e8b"));

            migrationBuilder.DropColumn(
                name: "PopularityScore",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "views",
                table: "ShopProducts");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("15eb8257-86f4-46b7-b354-dde58cd0acac"), "d66a6449-670c-46b2-be46-c8d6e5a81a96", null, "Admin", null },
                    { new Guid("eff50466-9910-4446-8120-5ced4d6acb0b"), "131026cb-b567-4e2b-9016-3f9617614982", null, "Staff", null },
                    { new Guid("f5971527-6b0c-48a7-bdb3-2abad65b44b4"), "6f514667-8e4e-40cb-8539-2e89bbc92cd0", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "CitizenIdentityCard", "CitizenIdentityCardBackImage", "CitizenIdentityCardFrontImage", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCardImage", "StudentNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("43051bc4-ffd0-42af-aa75-8d49ddeb64f9"), 0, null, null, null, "c01cc2cb-3672-49dc-a3cb-ec355a4db695", "Customer@gmail.com", false, "System", "Customer", false, null, null, null, "AQAAAAEAACcQAAAAELomZyU0CO0m7+sddL1pfm1b93VOZ2vpvHxOxeZj7vYk1mPriiSDzEalEffhnC59+w==", null, false, null, null, null, false, "Customer@gmail.com" },
                    { new Guid("6a25b44c-be6d-4a9a-8c79-9e415c75684a"), 0, null, null, null, "eaa372eb-283b-4551-80db-52b2dc9a0606", "admin@gmail.com", false, "System", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEFnanf+ubzub9xwr95Q94a92iTtATfMCiejMXc5LINw2UNIkzG4ubsMAjaHjt3+NsA==", null, false, null, null, null, false, "admin@gmail.com" },
                    { new Guid("d1cd1187-d207-4da4-8bc4-79c2086f6f18"), 0, null, null, null, "d6cb762b-c561-4610-8577-0ae24530ec81", "staff@gmail.com", false, "System", "Staff", false, null, null, null, "AQAAAAEAACcQAAAAEGJ4elRVlJuoksjuZMK48LwuC4bgm4ugLhZAjArCdP/9/BABVY8ZUfjyBiRhv4UMgg==", null, false, null, null, null, false, "staff@gmail.com" }
                });
        }
    }
}
