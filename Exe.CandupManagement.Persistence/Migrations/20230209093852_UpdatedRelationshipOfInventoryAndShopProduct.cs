using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedRelationshipOfInventoryAndShopProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_InventoryId",
                table: "ShopProducts",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_Inventories_InventoryId",
                table: "ShopProducts",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_Inventories_InventoryId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_InventoryId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "ShopProducts");
        }
    }
}
