using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympicGamesKingslee.Models;

namespace OlympicGamesKingslee.Controllers
{
    public class HomeController : Controller
    {
        private OlympicsContext context;

        public HomeController (OlympicsContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeCategory = "all", string activeGameType = "all")
        {
            ViewBag.ActiveCategory = activeCategory;
            ViewBag.ActiveGameType = activeGameType;

            // get list of categories and game types from database
            List<Category> categories = context.Categories.ToList();
            List<GameType> gameTypes = context.GameTypes.ToList();

            // insert default "All" value at front of each list
            categories.Insert(0, new Category { CategoryID = "all", Name = "All" });
            gameTypes.Insert(0, new GameType { GameTypeID = "all", Name = "All" });

            // store lists in view bag
            ViewBag.Categories = categories;
            ViewBag.GameTypes = gameTypes;

            // get olympics - filter by categories and game types
            IQueryable<Olympics> query = context.Olympics;
            if (activeCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCategory.ToLower());
            if (activeGameType != "all")
                query = query.Where(
                    t => t.GameType.GameTypeID.ToLower() == activeGameType.ToLower());

            // pass olympics to view as model
            var olympics = query.ToList();
            return View(olympics);

        }
    }
}
