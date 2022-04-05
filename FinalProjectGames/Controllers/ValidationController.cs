using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using FinalProjectGames.Models;

namespace FinalProjectGames.Controllers
{
    public class ValidationController : Controller
    {
        private FinalProjectGamesContext data { get; set; }

        public ValidationController(FinalProjectGamesContext ctx) => data = ctx;

 /*       public JsonResult CheckDate(string date)
        {
            DateTime parsedDate;
            bool isDateTime = false;

            // checking for empty date intput.
            if (string.IsNullOrEmpty(date))
            {
                return Json("Date can not be empty.");
            }

            //making sure date provided is valid 
            isDateTime = DateTime.TryParse(date, out parsedDate);

            if (isDateTime == false)
            {
                return Json("Please enter a valid date.");
            }

            var gameWithDateCount = data.Games.Where(t => t.Date == parsedDate).Count();

            if (gameWithDateCount > 0)
            {
                string msg = $"There is already a Game with the provided date: {date}";
                return Json(msg);
            }

            return Json(true);
        }*/
    }
}
