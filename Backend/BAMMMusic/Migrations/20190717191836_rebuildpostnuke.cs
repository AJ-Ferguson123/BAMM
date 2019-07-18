using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class rebuildpostnuke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtistName = table.Column<string>(nullable: true),
                    ArtistImage = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Hometown = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumTitle = table.Column<string>(nullable: true),
                    AlbumImage = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Date = table.Column<int>(nullable: false),
                    ArtistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ArtistId = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentDetails = table.Column<string>(nullable: true),
                    SongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagTitle = table.Column<string>(nullable: true),
                    SongId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tags_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Age", "ArtistImage", "ArtistName", "Hometown" },
                values: new object[] { 1, 57, "/Images/princeMusician1.jpg/", "Prince", "Minneapolis, Minnesota" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "Age", "ArtistImage", "ArtistName", "Hometown" },
                values: new object[] { 2, 49, "/Images/queen2.jpg/", "Queen", "London" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumImage", "AlbumTitle", "ArtistId", "Date", "Label" },
                values: new object[,]
                {
                    { 1, "loveSymbol.jpg", "Love Symbol", 1, 1992, "Rhino/Warner Brothers" },
                    { 2, "princeSignOTimes.png", "Sign Of the Times", 1, 1987, "Paisley Park" },
                    { 3, "QueenKillers.png", "Live Killers", 2, 1979, "EMI-Elektra" },
                    { 4, "NewsWorld", "News Of The World", 2, 1977, "EMI-Elektra" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "AlbumId", "ArtistId", "Duration", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "3:31", "Sexy MF" },
                    { 2, 1, 1, "3:18", "And God Created Woman'" },
                    { 3, 2, 1, "3:42", "Sign O the Times" },
                    { 4, 2, 1, "3:58", "U Got the Look" },
                    { 5, 3, 2, "2:07", "You're My Best Friend" },
                    { 6, 3, 2, "1:59", "Killer Queen" },
                    { 7, 4, 2, "3:01", "We Are the Champions" },
                    { 8, 4, 2, "2:02", "We Will Rock You" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "CommentDetails", "SongId" },
                values: new object[,]
                {
                    { 1, "I'm a little offended by the title, but man.. is this song GREAT!", 1 },
                    { 2, "As a self-described feminist, I love this song!", 2 },
                    { 3, "This is such a great party song!", 3 },
                    { 4, "I feel like this song has a deeper meaning than I understand... Not a huge fan..", 4 },
                    { 5, "My husband and I danced to this for our first dance. Such a beautiful song.", 5 },
                    { 6, "I always sing along when this song is on the radio. So catchy!", 6 },
                    { 7, "I just won a really intense game of beer pong.... obviously I've had to blast this song for the past 3 days. Classic.", 7 },
                    { 8, "You just can't not stomp your foot along with the beat... Such a classic song!", 8 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "SongId", "TagTitle" },
                values: new object[,]
                {
                    { 4, 1, "cool" },
                    { 7, 2, "Smooth Melody" },
                    { 8, 3, "Statment Song" },
                    { 5, 4, "groovy" },
                    { 6, 5, "Love Song" },
                    { 3, 6, "Live Music" },
                    { 2, 7, "Sing-Along" },
                    { 1, 8, "Rock & Roll" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SongId",
                table: "Comments",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_SongId",
                table: "Tags",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
