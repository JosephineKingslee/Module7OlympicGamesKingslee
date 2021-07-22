using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesKingslee.Models
{
    public class OlympicsViewModel
    {
        public Olympics olympics { get; set; }
        public string ActiveCategory { get; set; }
        public string ActiveGameType { get; set; }
    }
}
