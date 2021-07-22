using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympicGamesKingslee.Models;

namespace OlympicGamesKingslee.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicsSession(HttpContext.Session);
            var model = new OlympicsListViewModel
            {
                ActiveCategory = session.GetActiveCategory(),
                ActiveGameType = session.GetActiveGameType(),
                Olympics = session.GetMyOlympics()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicsSession(HttpContext.Session);
            session.RemoveMyOlympics();

            TempData["message"] = "Favorite teams cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveCategory = session.GetActiveCategory(),
                    ActiveGameType = session.GetActiveGameType()
                });

        }

    }
}
