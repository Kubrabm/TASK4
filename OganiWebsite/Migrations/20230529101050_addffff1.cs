using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OganiWebsite.Migrations
{
    public partial class addffff1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "FeatProducts");

            migrationBuilder.DropColumn(
                name: "Tittle",
                table: "Colors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "FeatProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tittle",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
