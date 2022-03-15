using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Library.Models;
using BookStore.Library;

namespace BookstoreWebApp.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genreToCreate)
        {
            try
            {
                BookStoreAdminFunctions.AddGenre(genreToCreate);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var genre = BookStoreFunctions.GetGenreByIdFull(id);
            return View(genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre)
        {
            try
            {
                BookStoreAdminFunctions.EditGenre(genre);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            var genre = BookStoreFunctions.GetGenreByIdFull(id);
            return View(genre);
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre genre)
        {
            try
            {
                BookStoreAdminFunctions.DeleteGenre(genre);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
