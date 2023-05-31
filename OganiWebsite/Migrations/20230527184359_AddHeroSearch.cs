using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OganiWebsite.Migrations
{
    public partial class AddHeroSearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "heroSearches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Btn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BtnText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_heroSearches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "heroSearches");
        }
    }
}
