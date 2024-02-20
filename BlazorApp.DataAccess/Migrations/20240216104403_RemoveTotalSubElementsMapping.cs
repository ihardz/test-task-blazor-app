using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTotalSubElementsMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSubElements",
                table: "Windows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSubElements",
                table: "Windows",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
