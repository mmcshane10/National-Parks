﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.Models;

namespace NationalParks.Migrations
{
    [DbContext(typeof(NationalParksContext))]
    [Migration("20191101180249_moreSeeds")]
    partial class moreSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParks.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Established");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<string>("Size");

                    b.Property<string>("States");

                    b.Property<string>("Visitors");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Description = "The Grand Canyon, carved by the mighty Colorado River, is 277 miles (446 km) long, up to 1 mile (1.6 km) deep, and up to 15 miles (24 km) wide. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls, visible from both the north and south rims.",
                            Established = "February 26, 1919 ",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/USA_09847_Grand_Canyon_Luca_Galuzzi_2007.jpg/200px-USA_09847_Grand_Canyon_Luca_Galuzzi_2007.jpg",
                            Name = "Grand Canyon",
                            Size = "1,201,647.03 acres",
                            States = "Arizona",
                            Visitors = "6,380,495 "
                        },
                        new
                        {
                            ParkId = 2,
                            Description = "Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows.",
                            Established = "November 19, 1919",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Angels_Landing.jpg/200px-Angels_Landing.jpg",
                            Name = "Zion",
                            Size = "147,242.66 acres",
                            States = "Utah",
                            Visitors = "4,320,033"
                        },
                        new
                        {
                            ParkId = 3,
                            Description = "Situated on the Yellowstone Caldera, the park has an expansive network of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, and regularly erupting geysers, the best-known being Old Faithful.",
                            Established = "March 1, 1872",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg/200px-Grand_Prismatic_Spring_and_Midway_Geyser_Basin_from_above.jpg",
                            Name = "Yellowstone",
                            Size = "2,219,790.71 acres",
                            States = "Wyoming, Montana, Idaho",
                            Visitors = "4,115,000"
                        },
                        new
                        {
                            ParkId = 4,
                            Description = "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.",
                            Established = "October 1, 1890",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/YosemitePark2_amk.jpg/200px-YosemitePark2_amk.jpg",
                            Name = "Yosemite",
                            Size = "761,747.50 acres",
                            States = "California",
                            Visitors = "4,009,436"
                        },
                        new
                        {
                            ParkId = 5,
                            Description = "Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet high.",
                            Established = "May 22, 1902",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Crater_lake_oregon.jpg/200px-Crater_lake_oregon.jpg",
                            Name = "Crater Lake",
                            Size = "183,224.05 acres",
                            States = "Oregon",
                            Visitors = "720,659"
                        },
                        new
                        {
                            ParkId = 6,
                            Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.",
                            Established = "February 26, 1919",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Bass_Harbor_Head_Light_Station_2016.jpg/200px-Bass_Harbor_Head_Light_Station_2016.jpg",
                            Name = "Acadia",
                            Size = "49,075.26 acres",
                            States = "Maine",
                            Visitors = "3,537,575"
                        },
                        new
                        {
                            ParkId = 7,
                            Description = "Situated on the Olympic Peninsula, this park includes a wide range of ecosystems from Pacific shoreline to temperate rainforests to the alpine slopes of the Olympic Mountains, the tallest of which is Mount Olympus.",
                            Established = "June 29, 1938",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Acer_macrophyllum_in_Hoh_Rain_Forest.jpg/200px-Acer_macrophyllum_in_Hoh_Rain_Forest.jpg",
                            Name = "Olympic",
                            Size = "922,649.41 acres",
                            States = "Washington",
                            Visitors = "3,104,455"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
