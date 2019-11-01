using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Established", "ImageURL", "Name", "Size", "States", "Visitors" },
                values: new object[] { 8, "The U.S. half of Waterton-Glacier International Peace Park, this park includes 26 glaciers and 130 named lakes surrounded by Rocky Mountain peaks. There are historic hotels and a landmark road called the Going-to-the-Sun Road in this region of rapidly receding glaciers.", "May 11, 1910", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/St_Mary_Lake_-_Wild_goose_Island.jpg/200px-St_Mary_Lake_-_Wild_goose_Island.jpg", "Glacier", "1,013,125.99 acres", "Montana", "2,965,309" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);
        }
    }
}
