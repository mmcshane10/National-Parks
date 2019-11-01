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

                    new Park { ParkId = 2, Name = "Zion", Description = "Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows.", Established = "November 19, 1919", States = "Utah", Size = "147,242.66 acres", Visitors = "4,320,033", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Angels_Landing.jpg/200px-Angels_Landing.jpg" },

                    new Park { ParkId = 3, Name = "Yellowstone", Description = "Situated on the Yellowstone Caldera, the park has an expansive network of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, and regularly erupting geysers, the best-known being Old Faithful.", Established = "March 1, 1872", States = "Wyoming, Montana, Idaho", Size = "2,219,790.71 acres", Visitors = "4,115,000", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg/200px-Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg" },

                    new Park { ParkId = 4, Name = "Yosemite", Description = "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.", Established = "October 1, 1890", States = "California", Size = "761,747.50 acres", Visitors = "4,009,436", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/YosemitePark2_amk.jpg/200px-YosemitePark2_amk.jpg" },

                    new Park { ParkId = 5, Name = "Crater Lake", Description = "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.", Established = "May 22, 1902", States = "Oregon", Size = "183,224.05 acres", Visitors = "720,659", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Crater_lake_oregon.jpg/200px-Crater_lake_oregon.jpg" },

                    new Park { ParkId = 6, Name = "Acadia", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", Established = "February 26, 1919", States = "Maine", Size = "49,075.26 acres", Visitors = "3,537,575", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Bass_Harbor_Head_Light_Station_2016.jpg/200px-Bass_Harbor_Head_Light_Station_2016.jpg" },

                    new Park { ParkId = 7, Name = "Olympic", Description = "Situated on the Olympic Peninsula, this park includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the alpine slopes of the Olympic Mountains, the tallest of which is Mount Olympus.", Established = "June 29, 1938", States = "Washington", Size = "922,649.41 acres", Visitors = "3,104,455", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Acer_macrophyllum_in_Hoh_Rain_Forest.jpg/200px-Acer_macrophyllum_in_Hoh_Rain_Forest.jpg" },

                    new Park { ParkId = 8, Name = "Glacier", Description = "The U.S. half of Waterton-Glacier International Peace Park, this park includes 26 glaciers and 130 named lakes surrounded by Rocky Mountain peaks. There are historic hotels and a landmark road called the Going-to-the-Sun Road in this region of rapidly receding glaciers.", Established = "May 11, 1910", States = "Montana", Size = "1,013,125.99 acres", Visitors = "2,965,309", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/St_Mary_Lake_-_Wild_goose_Island.jpg/200px-St_Mary_Lake_-_Wild_goose_Island.jpg" },

                    new Park { ParkId = 9, Name = "Bryce Canyon", Description = "Bryce Canyon is a geological amphitheater on the Paunsaugunt Plateau with hundreds of tall, multicolored sandstone hoodoos formed by erosion. The region was originally settled by Native Americans and later by Mormon pioneers.", Established = "February 25, 1928", States = "Utah", Size = "35,835.08 acres", Visitors = "2,679,478", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Bryce_Canyon_Hoodoos_Amphitheater.jpg/200px-Bryce_Canyon_Hoodoos_Amphitheater.jpg" },

                    new Park { ParkId = 10, Name = "Gateway Arch", Description = "The Gateway Arch is a 630-foot (192 m) (both high and wide) catenary arch built to commemorate the Lewis and Clark Expedition, initiated by Thomas Jefferson, and the subsequent westward expansion of the country.", Established = "February 22, 2018", States = "Missouri", Size = "192.83 acres", Visitors = "2,016,180", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/St_Louis_night_expblend.jpg/200px-St_Louis_night_expblend.jpg" },

                    new Park { ParkId = 11, Name = "Death Valley", Description = "Death Valley is the hottest, lowest, and driest place in the United States, with daytime temperatures that have exceeded 130 °F (54 °C). The park protects Badwater Basin and its vast salt flats located at the lowest elevation in North America, −282 ft.", Established = "October 31, 1994", States = "California", Size = "13,372,981.42 acres", Visitors = "1,678,660", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Mesquite_Sand_Dunes_in_Death_Valley.jpg/200px-Mesquite_Sand_Dunes_in_Death_Valley.jpg" },

                    new Park { ParkId = 12, Name = "Shenandoah", Description = "Shenandoah's Blue Ridge Mountains are covered by hardwood forests that teem with a wide variety of wildlife. The Skyline Drive and Appalachian Trail run the entire length of this narrow park, along with more than 500 miles of hiking trails passing scenic overlooks and cataracts of the Shenandoah River.", Established = "December 26, 1935", States = "Virginia", Size = "199,223.77 acres", Visitors = "1,264,880", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Early_Fall_at_Dark_Hollow_Falls_%2822028259442%29.jpg/200px-Early_Fall_at_Dark_Hollow_Falls_%2822028259442%29.jpg" },

                    new Park { ParkId = 13, Name = "Badlands", Description = "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils.", Established = "November 10, 1978", States = "South Dakota", Size = "242,755.94 acres", Visitors = "1,008,942", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/BadlandsView3.jpg/200px-BadlandsView3.jpg" },

                    new Park { ParkId = 14, Name = "Everglades", Description = "The Everglades are the largest tropical wilderness in the United States. This mangrove and tropical rainforest ecosystem and marine estuary is home to 36 protected species, including the Florida panther, American crocodile, and West Indian manatee.", Established = "May 30, 1934", States = "Florida", Size = "1,508,938.57 acres", Visitors = "597,124", ImageURL = "https://en.wikipedia.org/wiki/File:Everglades_National_Park_cypress.jpg" },

                    new Park { ParkId = 15, Name = "Gates of The Artic", Description = "The country's northernmost park protects an expanse of pure wilderness in Alaska's Brooks Range and has no park facilities. The land is home to Alaska Natives who have relied on the land and caribou for 11,000 years.", Established = "December 2, 1980", States = "Alaska", Size = "7,523,897.45 acres ", Visitors = "9,591", ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/GatesofArctic.jpg/200px-GatesofArctic.jpg" }
                );
        }
    }
}