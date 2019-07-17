using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class picture2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "/images/princeMusician1.jpg/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "~/images/princeMusician1.jpg");
        }
    }
}
