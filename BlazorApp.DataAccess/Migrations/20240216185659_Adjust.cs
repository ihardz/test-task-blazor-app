using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Adjust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "IX_States_Abbreviation",
                table: "States",
                newName: "IX_Abbreviation_Unique");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Windows",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Abbreviation",
                table: "States",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)");

            migrationBuilder.CreateIndex(
                name: "IX_Element_WindowId_Unique",
                table: "SubElements",
                columns: new[] { "Element", "WindowId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Element_WindowId_Unique",
                table: "SubElements");

            migrationBuilder.RenameIndex(
                name: "IX_Abbreviation_Unique",
                table: "States",
                newName: "IX_States_Abbreviation");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Windows",
                type: "int",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Abbreviation",
                table: "States",
                type: "nvarchar(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)");
        }
    }
}
