using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exe.CandupManagement.Persistence.Migrations
{
    public partial class UpdatedRelationshipOfOrderAndOrderPaymentInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPaymentInformation_OrderItems_OrderItemId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropIndex(
                name: "IX_OrderPaymentInformation_OrderItemId",
                table: "OrderPaymentInformation");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "OrderPaymentInformation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "OrderPaymentInformation",
                type: "int",
                nullable: true);

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
        }
    }
}
