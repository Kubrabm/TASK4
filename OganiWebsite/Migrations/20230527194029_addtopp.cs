using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OganiWebsite.Migrations
{
    public partial class addtopp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_heroSearches",
                table: "heroSearches");

            migrationBuilder.RenameTable(
                name: "heroSearches",
                newName: "HeroSearches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroSearches",
                table: "HeroSearches",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TopProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price1 = table.Column<double>(type: "float", nullable: false),
                    ImgUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price2 = table.Column<double>(type: "float", nullable: false),
                    ImgUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price3 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopProducts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroSearches",
                table: "HeroSearches");

            migrationBuilder.RenameTable(
                name: "HeroSearches",
                newName: "heroSearches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_heroSearches",
                table: "heroSearches",
                column: "Id");
        }
    }
}
