using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FinalProjectGames.Models;

namespace FinalProjectGames.Controllers
{
    public class HomeController : Controller
    {
        private FinalProjectGamesContext data { get; set; }

        public HomeController(FinalProjectGamesContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var games = data.Games.OrderBy(t => t.Name).ToList();
            return View(games);
        }

        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.GameTypes = data.GameTypes.ToList();
            return View(new Game());
        }

    [HttpPost]
        public IActionResult Add(Game game)
        {
            if (ModelState.IsValid) {
                GameType gameType = data.GameTypes.Where( g => g.GameTypeId == game.GameTypeId).First();
                game.GameType = gameType.Name;
                data.Games.Add(game);
                data.SaveChanges();

                return RedirectToAction("Index");
            } 
            else {
                ModelState.AddModelError("", "Please correct all errors");
                return View(game);
            }
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var game = data.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public RedirectToActionResult Delete(Game game)
        {
            data.Remove(game);
            data.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}
