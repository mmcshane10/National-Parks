using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class moarSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { 9, "Bryce Canyon is a geological amphitheater on the Paunsaugunt Plateau with hundreds of tall, multicolored sandstone hoodoos formed by erosion. The region was originally settled by Native Americans and later by Mormon pioneers.", "February 25, 1928", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Bryce_Canyon_Hoodoos_Amphitheater.jpg/200px-Bryce_Canyon_Hoodoos_Amphitheater.jpg", "Bryce Canyon", "35,835.08 acres", "Utah", "2,679,478" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { 10, "The Gateway Arch is a 630-foot (192 m) (both high and wide) catenary arch built to commemorate the Lewis and Clark Expedition, initiated by Thomas Jefferson, and the subsequent westward expansion of the country.", "February 22, 2018", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/St_Louis_night_expblend.jpg/200px-St_Louis_night_expblend.jpg", "Gateway Arch", "192.83 acres", "Missouri", ",016,180" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
