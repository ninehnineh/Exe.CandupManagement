using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class seedingAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("2c38a83c-2fa2-435e-a64e-7524d973f608"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8f43a91f-7995-4cfc-936b-1d3eb3b2c955"));

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("c313bfaf-0081-4bb2-bcb3-e20e4fedcc52"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b41b0acc-ad50-4eef-a3c8-18710c3d5993"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bf15bdbb-4729-42e4-ab3d-991c17ec692d"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f68acb19-abb8-4319-af48-a2b087cb262e"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("2c38a83c-2fa2-435e-a64e-7524d973f608"), "9e347b84-fbb6-4557-86d2-2e94278b3bcf", null, "Staff", null },
                    { new Guid("8f43a91f-7995-4cfc-936b-1d3eb3b2c955"), "b94b88eb-7e8f-447e-9769-84b89ee25c1e", null, "Admin", null },
                    { new Guid("c313bfaf-0081-4bb2-bcb3-e20e4fedcc52"), "5deab90f-7df6-443f-b22f-43f10bdf0974", null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "CitizenIdentityCard", "CitizenIdentityCardBackImage", "CitizenIdentityCardFrontImage", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCardImage", "StudentNumber", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("b41b0acc-ad50-4eef-a3c8-18710c3d5993"), 0, null, null, null, "cbb8e616-10ee-4547-8383-4e54cb89db20", "staff@gmail.com", false, "System", "Staff", false, null, null, null, "AQAAAAEAACcQAAAAEImVnzAmCe6A/bmFInBfsKlMeuEfnWiwTDCX8AGFQEAkoegs/IEwQzUxWRGs8fgK5w==", null, false, null, null, null, false, "staff@gmail.com" },
                    { new Guid("bf15bdbb-4729-42e4-ab3d-991c17ec692d"), 0, null, null, null, "8cb27b07-1783-4abe-aef9-3daf513f02f3", "Customer@gmail.com", false, "System", "Customer", false, null, null, null, "AQAAAAEAACcQAAAAEENhKxe4RgC5RFbXKgHY51W2mRFNkpsCEoCIm9PIuXRDy4XMNrPuiFttpNtTVOp0dQ==", null, false, null, null, null, false, "Customer@gmail.com" },
                    { new Guid("f68acb19-abb8-4319-af48-a2b087cb262e"), 0, null, null, null, "10f6b5ec-4755-41f1-8fc8-84f491c44144", "admin@gmail.com", false, "System", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEF/4aBXRz/bxf1T5gIAwLo60Jd3aMVG9JCT40gma5ik0WunZgxrn2ra7yrAkCM1OpQ==", null, false, null, null, null, false, "admin@gmail.com" }
                });
        }
    }
}
