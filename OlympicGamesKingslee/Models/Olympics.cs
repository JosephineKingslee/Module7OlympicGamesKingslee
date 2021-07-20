using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlympicGamesKingslee.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicGamesKingslee.Models
{
    public class Olympics
    { 
        [Key]
        public string CountryID { get; set; }
        public string Name { get; set; }
        public GameType GameType { get; set; }
        public string Sport { get; set; }
        public Category Category { get; set; }
        public string FlagImage { get; set; }
    }
}
