using Microsoft.EntityFrameworkCore.Migrations;

namespace BAMMMusic.Migrations
{
    public partial class changedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Albums",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "Date",
                value: "1992");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "Date",
                value: "1987");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                columns: new[] { "AlbumImage", "Date" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/0/05/Queen_Live_Killers.png", "1979" });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4,
                column: "Date",
                value: "1977");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Date",
                table: "Albums",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "Date",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "Date",
                value: 1987);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                columns: new[] { "AlbumImage", "Date" },
                values: new object[] { "", 1979 });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4,
                column: "Date",
                value: 1977);
        }
    }
}
