using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
    public class NationalParksContext : DbContext
    {
        public NationalParksContext(DbContextOptions<NationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Grand Canyon", Description = "The Grand Canyon, carved by the mighty Colorado River, is 277 miles (446 km) long, up to 1 mile (1.6 km) deep, and up to 15 miles (24 km) wide. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls, visible from both the north and south rims.", Established = "February 26, 1919 ", States = "Arizona", Size = "1,201,647.03 acres", Visitors = "6,380,495 ", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/USA_09847_Grand_Canyon_Luca_Galuzzi_2007.jpg/200px-USA_09847_Grand_Canyon_Luca_Galuzzi_2007.jpg" },

                    new Park { ParkId = 2, Name = "", Description = "", Established = "", States = "", Size = "", Visitors = "", ImageURL = "" },

                    new Park { ParkId = 3, Name = "", Description = "", Established = "", States = "", Size = "", Visitors = "", ImageURL = "" }
                );
        }
    }
}