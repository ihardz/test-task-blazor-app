using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationOrderWindow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Windows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Windows_OrderId",
                table: "Windows",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Windows_Orders_OrderId",
                table: "Windows",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Windows_Orders_OrderId",
                table: "Windows");

            migrationBuilder.DropIndex(
                name: "IX_Windows_OrderId",
                table: "Windows");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Windows");
        }
    }
}
