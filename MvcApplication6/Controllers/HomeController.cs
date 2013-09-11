using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication6.Models;
//using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var repo = new AllAmericanRepository();
            var players = repo.GetPlayers();

            return View("PlayerList", players);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditPlayer()
        {
            
            var newPlayer = new Player()
            {
                FirstName = "Joe",
                LastName = "Bag O'Donuts",
                Year = 2013
            };


            return View("EditPlayer", 1);

        }

        [HttpPost]
        public ActionResult EditPlayer(Player editedPlayer)
        {
            
            // Validate the data

            // Save the data

            ViewBag.Stuff = "I Like Chicken!";

            return View(editedPlayer);

        }



    }


}                           
