﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGamesKingslee.Models;

namespace OlympicGamesKingslee.Migrations
{
    [DbContext(typeof(OlympicsContext))]
    partial class OlympicsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OlympicGamesKingslee.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "indoor",
                            Name = "Indoor"
                        },
                        new
                        {
                            CategoryID = "outdoor",
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("OlympicGamesKingslee.Models.GameType", b =>
                {
                    b.Property<string>("GameTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameTypeID");

                    b.ToTable("GameTypes");

                    b.HasData(
                        new
                        {
                            GameTypeID = "winterOlympics",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameTypeID = "summerOlympics",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameTypeID = "paralympicsGames",
                            Name = "Paralympic Games"
                        },
                        new
                        {
                            GameTypeID = "youthOlympicGames",
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("OlympicGamesKingslee.Models.Olympics", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FlagImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sport")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameTypeID");

                    b.ToTable("Olympics");

                    b.HasData(
                        new
                        {
                            CountryID = "can",
                            CategoryID = "indoor",
                            FlagImage = "Canada.png",
                            GameTypeID = "winterOlympics",
                            Name = "Canada",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryID = "swe",
                            CategoryID = "indoor",
                            FlagImage = "Sweden.png",
                            GameTypeID = "winterOlympics",
                            Name = "Sweden",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryID = "gre",
                            CategoryID = "indoor",
                            FlagImage = "Great_Britain.png",
                            GameTypeID = "winterOlympics",
                            Name = "Great Britain",
                            Sport = "Curling"
                        },
                        new
                        {
                            CountryID = "jam",
                            CategoryID = "outdoor",
                            FlagImage = "Jamaica.png",
                            GameTypeID = "winterOlympics",
                            Name = "Jamaica",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryID = "ita",
                            CategoryID = "outdoor",
                            FlagImage = "Italy.png",
                            GameTypeID = "winterOlympics",
                            Name = "Italy",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryID = "jap",
                            CategoryID = "outdoor",
                            FlagImage = "Japan.png",
                            GameTypeID = "winterOlympics",
                            Name = "Japan",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            CountryID = "ger",
                            CategoryID = "indoor",
                            FlagImage = "Germany.png",
                            GameTypeID = "summerOlympics",
                            Name = "Germany",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryID = "chi",
                            CategoryID = "indoor",
                            FlagImage = "China.png",
                            GameTypeID = "summerOlympics",
                            Name = "China",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryID = "mex",
                            CategoryID = "indoor",
                            FlagImage = "Mexico.png",
                            GameTypeID = "summerOlympics",
                            Name = "Mexico",
                            Sport = "Diving"
                        },
                        new
                        {
                            CountryID = "bra",
                            CategoryID = "outdoor",
                            FlagImage = "Brazil.png",
                            GameTypeID = "summerOlympics",
                            Name = "Brazil",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryID = "net",
                            CategoryID = "outdoor",
                            FlagImage = "Netherlands.png",
                            GameTypeID = "summerOlympics",
                            Name = "Netherlands",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryID = "usa",
                            CategoryID = "outdoor",
                            FlagImage = "USA.png",
                            GameTypeID = "summerOlympics",
                            Name = "USA",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            CountryID = "tha",
                            CategoryID = "indoor",
                            FlagImage = "Thailand.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Thailand",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryID = "uru",
                            CategoryID = "indoor",
                            FlagImage = "Uruguay.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Uruguay",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CategoryID = "indoor",
                            FlagImage = "Ukraine.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Ukraine",
                            Sport = "Archery"
                        },
                        new
                        {
                            CountryID = "aus",
                            CategoryID = "outdoor",
                            FlagImage = "Austria.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Austria",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryID = "pak",
                            CategoryID = "outdoor",
                            FlagImage = "Pakistan.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Pakistan",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryID = "zim",
                            CategoryID = "outdoor",
                            FlagImage = "Zimbabwe.png",
                            GameTypeID = "paralympicsGames",
                            Name = "Zimbabwe",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            CountryID = "fra",
                            CategoryID = "indoor",
                            FlagImage = "France.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "France",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CategoryID = "indoor",
                            FlagImage = "Cyprus.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "Cyprus",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            CountryID = "rus",
                            CategoryID = "indoor",
                            FlagImage = "Russia.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "Russia",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            CountryID = "fin",
                            CategoryID = "outdoor",
                            FlagImage = "Finland.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "Finland",
                            Sport = "Skate Boarding"
                        },
                        new
                        {
                            CountryID = "slo",
                            CategoryID = "outdoor",
                            FlagImage = "Slovakia.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "Slovakia",
                            Sport = "Skate Boarding"
                        },
                        new
                        {
                            CountryID = "por",
                            CategoryID = "outdoor",
                            FlagImage = "Portugal.png",
                            GameTypeID = "youthOlympicGames",
                            Name = "Portugal",
                            Sport = "Skate Boarding"
                        });
                });

            modelBuilder.Entity("OlympicGamesKingslee.Models.Olympics", b =>
                {
                    b.HasOne("OlympicGamesKingslee.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.HasOne("OlympicGamesKingslee.Models.GameType", "GameType")
                        .WithMany()
                        .HasForeignKey("GameTypeID");

                    b.Navigation("Category");

                    b.Navigation("GameType");
                });
#pragma warning restore 612, 618
        }
    }
}
