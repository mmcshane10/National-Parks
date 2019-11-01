using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class additionalSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { "Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows.", "November 19, 1919", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Angels_Landing.jpg/200px-Angels_Landing.jpg", "Zion", "147,242.66 acres", "Utah", "4,320,033" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { "Situated on the Yellowstone Caldera, the park has an expansive network of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, and regularly erupting geysers, the best-known being Old Faithful.", "March 1, 1872", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg/200px-Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg", "Yellowstone", "2,219,790.71 acres", "Wyoming, Montana, Idaho", "4,115,000" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[,]
                {
                    { 4, "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.", "October 1, 1890", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/YosemitePark2_amk.jpg/200px-YosemitePark2_amk.jpg", "Yosemite", "761,747.50 acres", "California", "4,009,436" },
                    { 5, "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.", "May 22, 1902", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Crater_lake_oregon.jpg/200px-Crater_lake_oregon.jpg", "Crater Lake", "183,224.05 acres", "Oregon", "720,659" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { "", "", "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { "", "", "", "", "", "", "" });
        }
    }
}
