using BlazorApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

#nullable disable

namespace BlazorApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedSatesAndSubElementTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("States", nameof(State.Abbreviation), MigrationsData.StatesAbbreviations.ToArray());
            migrationBuilder.InsertData("SubElementTypes", nameof(SubElementType.Name), MigrationsData.SubElementTypes.ToArray());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM States", true);
            migrationBuilder.Sql("DELETE FROM SubElementTypes", true);
        }
    }
}
