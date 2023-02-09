using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedRelationshipOfOrderItemAndShopProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_OrderItems_OrderItemId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_OrderItemId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "ShopProducts");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ShopProductId",
                table: "OrderItems",
                column: "ShopProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_ShopProducts_ShopProductId",
                table: "OrderItems",
                column: "ShopProductId",
                principalTable: "ShopProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_ShopProducts_ShopProductId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_ShopProductId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_OrderItemId",
                table: "ShopProducts",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_OrderItems_OrderItemId",
                table: "ShopProducts",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
