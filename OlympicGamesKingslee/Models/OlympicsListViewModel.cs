using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGamesKingslee.Models
{
    public class OlympicsListViewModel : OlympicsViewModel
    {
        public List<Olympics> Olympics { get; set; }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = new List<Category>
                {
                    new Category{CategoryID = "all", Name = "all"}
                };
                categories.AddRange(value);
            }
        }

        private List<GameType> gameTypes;
        public List<GameType> GameTypes
        {
            get => gameTypes;
            set
            {
                gameTypes = new List<GameType>
                {
                    new GameType{GameTypeID = "all", Name = "all"}
                };
                gameTypes.AddRange(value);
            }
        }

        // methods to help view determine active link
        public string CheckActiveCategory(string c) =>
            c.ToLower() == ActiveCategory.ToLower() ? "active" : "";
        public string CheckActiveGameType(string g) =>
            g.ToLower() == ActiveGameType.ToLower() ? "active" : "";
    }
}
