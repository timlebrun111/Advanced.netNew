using BookstoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Library;

namespace BookstoreWebApp.Controllers
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
            var bookList = BookStoreFunctions.GetAllBooksFull();
            return View(bookList);
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Genres()
        {
            var genreList = BookStoreFunctions.GetAllGenres();
            return View(genreList);
        }

        public IActionResult Author()
        {
            var authorList = BookStoreFunctions.GetAllAuthors();
            return View(authorList);
        }
    }
}
