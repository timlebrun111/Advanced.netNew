using BlockBusterWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlockBusterWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Colors()
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Yellow");
            colors.Add("Black");
            ViewData["colors"] = colors;
            return View();
        }

        public IActionResult Movie()
        {
            List<string> movie = new List<string>();
            movie.Add("Saw");
            movie.Add("Jumanji");
            movie.Add("Avengers");
            ViewBag.movie = movie;

            return View();
        }

        public IActionResult Cities()
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Las Vegas");
            cities.Add("Austin");
            cities.Add("Madrid");
            cities.Add("Seattle");
            ViewBag.cities = cities;


            return View();
        }

        public IActionResult Hobbies()
        {
            List<string> hobbies = new List<string>();
            hobbies.Add("Watching Movies");
            hobbies.Add("Hanging out with friends");
            hobbies.Add("Watching Football");
            hobbies.Add("Playing Basketball");
            hobbies.Add("Playing Videogames");
            ViewData["hobbies"] = hobbies;


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
