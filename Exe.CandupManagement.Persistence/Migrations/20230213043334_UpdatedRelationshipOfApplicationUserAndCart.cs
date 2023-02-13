using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedRelationshipOfApplicationUserAndCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AppUsers_AppUserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts");

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
                name: "AppUserId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");

            migrationBuilder.AddColumn<Guid>(
                name: "UserForeignKey",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserForeignKey",
                table: "Carts",
                column: "UserForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AppUsers_UserForeignKey",
                table: "Carts",
                column: "UserForeignKey",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AppUsers_UserForeignKey",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserForeignKey",
                table: "Carts");

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

            migrationBuilder.DropColumn(
                name: "UserForeignKey",
                table: "Carts");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Carts",
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

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AppUsers_AppUserId",
                table: "Carts",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}
