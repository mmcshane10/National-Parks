using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class moreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { 6, "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", "February 26, 1919", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Bass_Harbor_Head_Light_Station_2016.jpg/200px-Bass_Harbor_Head_Light_Station_2016.jpg", "Acadia", "49,075.26 acres", "Maine", "3,537,575" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { 7, "Situated on the Olympic Peninsula, this park includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the alpine slopes of the Olympic Mountains, the tallest of which is Mount Olympus.", "June 29, 1938", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Acer_macrophyllum_in_Hoh_Rain_Forest.jpg/200px-Acer_macrophyllum_in_Hoh_Rain_Forest.jpg", "Olympic", "922,649.41 acres", "Washington", "3,104,455" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);
        }
    }
}
