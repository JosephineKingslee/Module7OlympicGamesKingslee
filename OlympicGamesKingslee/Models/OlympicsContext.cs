using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympicGamesKingslee.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicGamesKingslee.Models
{
    public class OlympicsContext : DbContext
    {
        public OlympicsContext(DbContextOptions<OlympicsContext> options)
            : base(options)
        { }

        public DbSet<Olympics> Olympics { get; set; }
        public DbSet<GameType> GameTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor"},
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
            );
            modelBuilder.Entity<GameType>().HasData(
                new GameType { GameTypeID = "winterOlympics", Name = "Winter Olympics" },
                new GameType { GameTypeID = "summerOlympics", Name = "Summer Olympics" },
                new GameType { GameTypeID = "paralympicsGames", Name = "Paralympic Games" },
                new GameType { GameTypeID = "youthOlympicGames", Name = "Youth Olympic Games" }
            );
            modelBuilder.Entity<Olympics>().HasData(
                new { CountryID = "can", Name = "Canada", GameTypeID = "winterOlympics",Sport = "Curling", CategoryID = "indoor", FlagImage = "Canada.png"},
                new { CountryID = "swe", Name = "Sweden", GameTypeID = "winterOlympics", Sport = "Curling", CategoryID = "indoor", FlagImage = "Sweden.png" },
                new { CountryID = "gre", Name = "Great Britain", GameTypeID = "winterOlympics", Sport = "Curling", CategoryID = "indoor", FlagImage = "Great_Britain.png" },
                new { CountryID = "jam", Name = "Jamaica", GameTypeID = "winterOlympics", Sport = "Bobsleigh", CategoryID = "outdoor", FlagImage = "Jamaica.png" },
                new { CountryID = "ita", Name = "Italy", GameTypeID = "winterOlympics", Sport = "Bobsleigh", CategoryID = "outdoor", FlagImage = "Italy.png" },
                new { CountryID = "jap", Name = "Japan", GameTypeID = "winterOlympics", Sport = "Bobsleigh", CategoryID = "outdoor", FlagImage = "Japan.png" },
                new { CountryID = "ger", Name = "Germany", GameTypeID = "summerOlympics", Sport = "Diving", CategoryID = "indoor", FlagImage = "Germany.png" },
                new { CountryID = "chi", Name = "China", GameTypeID = "summerOlympics", Sport = "Diving", CategoryID = "indoor", FlagImage = "China.png" },
                new { CountryID = "mex", Name = "Mexico", GameTypeID = "summerOlympics", Sport = "Diving", CategoryID = "indoor", FlagImage = "Mexico.png" },
                new { CountryID = "bra", Name = "Brazil", GameTypeID = "summerOlympics", Sport = "Road Cycling", CategoryID = "outdoor", FlagImage = "Brazil.png" },
                new { CountryID = "net", Name = "Netherlands", GameTypeID = "summerOlympics", Sport = "Road Cycling", CategoryID = "outdoor", FlagImage = "Netherlands.png" },
                new { CountryID = "usa", Name = "USA", GameTypeID = "summerOlympics", Sport = "Road Cycling", CategoryID = "outdoor", FlagImage = "USA.png" },
                new { CountryID = "tha", Name = "Thailand", GameTypeID = "paralympicsGames", Sport = "Archery", CategoryID = "indoor", FlagImage = "Thailand.png" },
                new { CountryID = "uru", Name = "Uruguay", GameTypeID = "paralympicsGames", Sport = "Archery", CategoryID = "indoor", FlagImage = "Uruguay.png" },
                new { CountryID = "ukr", Name = "Ukraine", GameTypeID = "paralympicsGames", Sport = "Archery", CategoryID = "indoor", FlagImage = "Ukraine.png" },
                new { CountryID = "aus", Name = "Austria", GameTypeID = "paralympicsGames", Sport = "Canoe Sprint", CategoryID = "outdoor", FlagImage = "Austria.png" },
                new { CountryID = "pak", Name = "Pakistan", GameTypeID = "paralympicsGames", Sport = "Canoe Sprint", CategoryID = "outdoor", FlagImage = "Pakistan.png" },
                new { CountryID = "zim", Name = "Zimbabwe", GameTypeID = "paralympicsGames", Sport = "Canoe Sprint", CategoryID = "outdoor", FlagImage = "Zimbabwe.png" },
                new { CountryID = "fra", Name = "France", GameTypeID = "youthOlympicGames", Sport = "Break Dancing", CategoryID = "indoor", FlagImage = "France.png" },
                new { CountryID = "cyp", Name = "Cyprus", GameTypeID = "youthOlympicGames", Sport = "Break Dancing", CategoryID = "indoor", FlagImage = "Cyprus.png" },
                new { CountryID = "rus", Name = "Russia", GameTypeID = "youthOlympicGames", Sport = "Break Dancing", CategoryID = "indoor", FlagImage = "Russia.png" },
                new { CountryID = "fin", Name = "Finland", GameTypeID = "youthOlympicGames", Sport = "Skate Boarding", CategoryID = "outdoor", FlagImage = "Finland.png" },
                new { CountryID = "slo", Name = "Slovakia", GameTypeID = "youthOlympicGames", Sport = "Skate Boarding", CategoryID = "outdoor", FlagImage = "Slovakia.png" },
                new { CountryID = "por", Name = "Portugal", GameTypeID = "youthOlympicGames", Sport = "Skate Boarding", CategoryID = "outdoor", FlagImage = "Portugal.png" }
            );
        }
    }
}
