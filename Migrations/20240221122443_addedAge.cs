using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutrition.Migrations
{
    /// <inheritdoc />
    public partial class addedAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Years",
                table: "UserProgress",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Years",
                table: "UserDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Years",
                table: "UserProgress");

            migrationBuilder.DropColumn(
                name: "Years",
                table: "UserDetails");
        }
    }
}
