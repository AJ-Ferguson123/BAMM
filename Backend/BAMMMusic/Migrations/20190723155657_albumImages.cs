using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class albumImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "AlbumImage",
                value: "https://upload.wikimedia.org/wikipedia/en/c/c2/Love_Symbol_Album_%28Prince_and_the_New_Power_Generation_album_-_cover_art%29.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "AlbumImage",
                value: "https://images-na.ssl-images-amazon.com/images/I/A1bbWtAHUtL._SX425_.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                column: "AlbumImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4,
                column: "AlbumImage",
                value: "https://images-na.ssl-images-amazon.com/images/I/810rfsma2tL._SX425_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "AlbumImage",
                value: "loveSymbol.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "AlbumImage",
                value: "princeSignOTimes.png");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                column: "AlbumImage",
                value: "QueenKillers.png");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4,
                column: "AlbumImage",
                value: "NewsWorld");
        }
    }
}
