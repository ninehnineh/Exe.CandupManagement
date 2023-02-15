using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class seedingAppRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("784a743f-ac45-4933-b275-e58d64c1b29c"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("aa0b7153-e261-493a-ad88-a3659d2e77ac"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c446b5bb-5fb0-4e59-ab54-eefe756e29ba"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("90042ec6-52dd-4d6e-a563-c81e6fecdff1"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdb2d430-1b77-4346-ad8b-da120ad4e4fc"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7178439-c581-425c-ab0a-71c85fd812d5"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("58fd9ee4-4e33-4099-82df-2a080d69e440"), "538802f6-e972-482c-b781-10ea1ed4d8df", null, "Admin", "ADMIN" },
                    { new Guid("5eb8d09f-7c6e-4a5d-ae91-24d5a577a9a3"), "ce7e0daf-5213-4e97-9d77-43c27ca17b9f", null, "Customer", "CUSTOMER" },
                    { new Guid("b1535e87-2af6-4b71-98a8-a72388ac26e0"), "61261486-01c0-46ad-beda-def962858081", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "CitizenIdentityCard", "CitizenIdentityCardBackImage", "CitizenIdentityCardFrontImage", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCardImage", "StudentNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("07be7b1a-77c4-4ed8-92d0-82805990f7e8"), 0, null, null, null, "6eec9365-be64-4988-978e-554a7d22c90d", "admin@gmail.com", false, "System", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMABUfLuhZ3Yh56/TTS/02WwcYuQd7nBNrqWYuVsqs+6jPmimG2ZQ2v3ZfdcpaFQaQ==", null, false, null, null, null, false, "admin@gmail.com" },
                    { new Guid("257aea8a-5f0d-4c0b-963a-cef4d80cd9ab"), 0, null, null, null, "ef108efd-2183-480e-8b33-b0f618041751", "staff@gmail.com", false, "System", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEFfHfOIlltpzPUho6CJ3hu3Xt3CuV/L4VcZ7oGDqqqWbHOghM+SRfeX+sUl1XCTdkg==", null, false, null, null, null, false, "staff@gmail.com" },
                    { new Guid("580bc2c7-b8ea-4965-99e9-cb7c15f67896"), 0, null, null, null, "0210068d-f4f6-4a6f-a187-5db718108d47", "Customer@gmail.com", false, "System", "Customer", false, null, "CUSTOMER@GMAIL.COM", "CUSTOMER@GMAIL.COM", "AQAAAAEAACcQAAAAECf6XANKyc+pSCKxgUdcGhdf6dvEBCJcrB0qAfe3Bwc8OxVBseFrS1xmc8pW7trKEw==", null, false, null, null, null, false, "Customer@gmail.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("58fd9ee4-4e33-4099-82df-2a080d69e440"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5eb8d09f-7c6e-4a5d-ae91-24d5a577a9a3"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b1535e87-2af6-4b71-98a8-a72388ac26e0"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("07be7b1a-77c4-4ed8-92d0-82805990f7e8"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("257aea8a-5f0d-4c0b-963a-cef4d80cd9ab"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("580bc2c7-b8ea-4965-99e9-cb7c15f67896"));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("784a743f-ac45-4933-b275-e58d64c1b29c"), "8caa6710-1c17-4a6e-89b5-2e33368341ad", null, "Customer", null },
                    { new Guid("aa0b7153-e261-493a-ad88-a3659d2e77ac"), "ef6e137b-e7a6-402f-b8af-4f5aab5031e1", null, "Staff", null },
                    { new Guid("c446b5bb-5fb0-4e59-ab54-eefe756e29ba"), "bccf906a-630a-4c24-b6cd-aa852197b81e", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "CitizenIdentityCard", "CitizenIdentityCardBackImage", "CitizenIdentityCardFrontImage", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCardImage", "StudentNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("90042ec6-52dd-4d6e-a563-c81e6fecdff1"), 0, null, null, null, "eac75726-3c3a-448a-b9fe-4cb2ca42cfe2", "admin@gmail.com", false, "System", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEI0LVwJbAslzw4aRbmCi5/JuYG36vKJffoQyH3pxZnKFDu0BUlJAMcptTDv4+IsiPg==", null, false, null, null, null, false, "admin@gmail.com" },
                    { new Guid("bdb2d430-1b77-4346-ad8b-da120ad4e4fc"), 0, null, null, null, "ae817a00-bbf0-42b2-a0c4-fcb849f13759", "staff@gmail.com", false, "System", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAECZhhsfPmZ0cH8Ue+qJNhBlx7TbNWgocaVZImEhPQy9UrcpSE1ZBrge6oNH0W1hEcg==", null, false, null, null, null, false, "staff@gmail.com" },
                    { new Guid("d7178439-c581-425c-ab0a-71c85fd812d5"), 0, null, null, null, "d0d4bd26-0b2a-4324-a0b4-d7715e124236", "Customer@gmail.com", false, "System", "Customer", false, null, "CUSTOMER@GMAIL.COM", "CUSTOMER@GMAIL.COM", "AQAAAAEAACcQAAAAEFK+GdMFtzOdXN4F9RkwNdDvo5u6hkRPiigxTvBNYvcOpleNAceV8XeasvNJ4UbSuA==", null, false, null, null, null, false, "Customer@gmail.com" }
                });
        }
    }
}
