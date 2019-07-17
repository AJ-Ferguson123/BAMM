using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class take6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "*/Images/princeMusician1.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ArtistImage",
                value: "*/Images/queen2.jpg/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "./Images/princeMusician1.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ArtistImage",
                value: "./Images/queen2.jpg/");
        }
    }
}
