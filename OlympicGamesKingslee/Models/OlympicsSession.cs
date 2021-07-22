using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicGamesKingslee.Models
{
    public class OlympicsSession
    {
        private const string OlympicsKey ="myolympics";
        private const string CountKey = "olympicsCount";
        private const string CategoriesKey = "categories";
        private const string GameTypeKey = "gameType";

        private ISession session { get; set; }
        public OlympicsSession (ISession session)
        {
            this.session = session;
        }

        public void SetMyOlympics(List<Olympics> olympics)
        {
            session.SetObject(OlympicsKey, olympics);
            session.SetInt32(CountKey, olympics.Count);
        }
        public List<Olympics> GetMyOlympics() =>
            session.GetObject<List<Olympics>>(OlympicsKey) ?? new List<Olympics>();
        public int GetMyOlympicsCount() => session.GetInt32(CountKey) ?? 0;

        public void SetActiveCategory(string activeCategory) =>
            session.SetString(CategoriesKey, activeCategory);
        public string GetActiveCategory() => session.GetString(CategoriesKey);

        public void SetActiveGameType(string activeGameType) =>
            session.SetString(GameTypeKey, activeGameType);
        public string GetActiveGameType() => session.GetString(GameTypeKey);

        public void RemoveMyOlympics()
        {
            session.Remove(OlympicsKey);
            session.Remove(CountKey);
        }
    
    }
}
