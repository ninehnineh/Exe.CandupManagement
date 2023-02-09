using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedRelationshipOfOrderAndShopProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "ShopProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderPaymentInformation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopProducts_OrderItemId",
                table: "ShopProducts",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderItemId",
                table: "Orders",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPaymentInformation_OrderId",
                table: "OrderPaymentInformation",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPaymentInformation_OrderItemId",
                table: "OrderPaymentInformation",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPaymentInformation_OrderItems_OrderItemId",
                table: "OrderPaymentInformation",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPaymentInformation_Orders_OrderId",
                table: "OrderPaymentInformation",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderItems_OrderItemId",
                table: "Orders",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProducts_OrderItems_OrderItemId",
                table: "ShopProducts",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPaymentInformation_OrderItems_OrderItemId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPaymentInformation_Orders_OrderId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderItems_OrderItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProducts_OrderItems_OrderItemId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopProducts_OrderItemId",
                table: "ShopProducts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderItemId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderPaymentInformation_OrderId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropIndex(
                name: "IX_OrderPaymentInformation_OrderItemId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "ShopProducts");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderPaymentInformation");
        }
    }
}
