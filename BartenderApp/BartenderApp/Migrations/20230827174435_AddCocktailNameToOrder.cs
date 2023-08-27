using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BartenderApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCocktailNameToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CocktailName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CocktailName",
                table: "Orders");
        }
    }
}
