using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OlympicGamesKingslee.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicGamesKingslee.Models
{
    public class GameType
    {
        public string GameTypeID { get; set; }
        public string Name { get; set; }
    }
}
