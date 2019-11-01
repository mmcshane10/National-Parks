using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class finalSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                column: "Visitors",
                value: "2,016,180");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[,]
                {
                    { 11, "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C). The park protects Badwater Basin and its vast salt flats located at the lowest elevation in North America, −282 ft.", "October 31, 1994", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Mesquite_Sand_Dunes_in_Death_Valley.jpg/200px-Mesquite_Sand_Dunes_in_Death_Valley.jpg", "Death Valley", "13,372,981.42 acres", "California", "1,678,660" },
                    { 12, "Shenandoah's Blue Ridge Mountains are covered by hardwood forests that teem with a wide variety of wildlife. The Skyline Drive and Appalachian Trail run the entire length of this narrow park, along with more than 500 miles of hiking trails passing scenic overlooks and cataracts of the Shenandoah River.", "December 26, 1935", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Early_Fall_at_Dark_Hollow_Falls_%2822028259442%29.jpg/200px-Early_Fall_at_Dark_Hollow_Falls_%2822028259442%29.jpg", "Shenandoah", "199,223.77 acres", "Virginia", "1,264,880" },
                    { 13, "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils.", "November 10, 1978", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/BadlandsView3.jpg/200px-BadlandsView3.jpg", "Badlands", "242,755.94 acres", "South Dakota", "1,008,942" },
                    { 14, "The Everglades are the largest tropical wilderness in the United States. This mangrove and tropical rainforest ecosystem and marine estuary is home to 36 protected species, including the Florida panther, American crocodile, and West Indian manatee.", "May 30, 1934", "https://en.wikipedia.org/wiki/File:Everglades_National_Park_cypress.jpg", "Everglades", "1,508,938.57 acres", "Florida", "597,124" },
                    { 15, "The country's northernmost park protects an expanse of pure wilderness in Alaska's Brooks Range and has no park facilities. The land is home to Alaska Natives who have relied on the land and caribou for 11,000 years.", "December 2, 1980", "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/GatesofArctic.jpg/200px-GatesofArctic.jpg", "Gates of The Artic", "7,523,897.45 acres ", "Alaska", "9,591" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                column: "Visitors",
                value: ",016,180");
        }
    }
}
