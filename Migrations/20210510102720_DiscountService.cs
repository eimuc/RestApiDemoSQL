using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiDemoSQL.Migrations
{
    public partial class DiscountService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplyDiscount",
                table: "Items",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplyDiscount",
                table: "Items");
        }
    }
}
