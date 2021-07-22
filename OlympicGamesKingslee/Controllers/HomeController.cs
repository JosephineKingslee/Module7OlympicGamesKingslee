using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympicGamesKingslee.Models;
using Microsoft.EntityFrameworkCore;

namespace OlympicGamesKingslee.Controllers
{
    public class HomeController : Controller
    {
        private OlympicsContext context;

        public HomeController (OlympicsContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeCategory = "all", string activeGameType = "all")
        {
            var session = new OlympicsSession(HttpContext.Session);
            session.SetActiveCategory(activeCategory);
            session.SetActiveGameType(activeGameType);

            var model = new OlympicsListViewModel
            {
                ActiveCategory = activeCategory,
                ActiveGameType = activeGameType,
                Categories = context.Categories.ToList(),
                GameTypes = context.GameTypes.ToList()
            };

            IQueryable<Olympics> query = context.Olympics;
            if (activeCategory != "all")
                query = query.Where(
                    t => t.Category.CategoryID.ToLower() == activeCategory.ToLower());
            if (activeGameType != "all")
                query = query.Where(
                    t => t.GameType.GameTypeID.ToLower() == activeGameType.ToLower());
            model.Olympics = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicsSession(HttpContext.Session);
            var model = new OlympicsViewModel
            {
                olympics = context.Olympics
                    .Include(t => t.Category)
                    .Include(t => t.GameType)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveGameType = session.GetActiveGameType(),
                ActiveCategory = session.GetActiveCategory()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(OlympicsViewModel data)
        {
            data.olympics = context.Olympics
                .Include(t => t.Category)
                .Include(t => t.GameType)
                .Where(t => t.CountryID == data.olympics.CountryID)
                .FirstOrDefault();

            var session = new OlympicsSession(HttpContext.Session);
            var olympics = session.GetMyOlympics();
            olympics.Add(data.olympics);
            session.SetMyOlympics(olympics);

            TempData["message"] = $"{data.olympics.Name} added to your favorites";

            return RedirectToAction("Index",
                new
                {
                    ActiveCategory = session.GetActiveCategory(),
                    ActiveGameType = session.GetActiveGameType()
                });
        }

    }
}