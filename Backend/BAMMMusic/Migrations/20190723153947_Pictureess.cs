using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class Pictureess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Prince_at_Coachella_%28cropped%29.jpg/230px-Prince_at_Coachella_%28cropped%29.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ArtistImage",
                value: "https://img.discogs.com/zn9McvDCNM8ZOWOtrKERq8Q386o=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/A-81013-1211978659.jpeg.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 1,
                column: "ArtistImage",
                value: "/Images/princeMusician1.jpg/");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 2,
                column: "ArtistImage",
                value: "/Images/queen2.jpg/");
        }
    }
}
