using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlockBuster;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlockBuster.Models;
using BlockBusterWebApp.Helpers;

namespace BlockBusterWebApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            var movie = BlockBusterBasicFunctions.GetMovieByIdFull(id);
            return View(movie);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {

            ViewBag.GenreId = DropDownFormatter.FormatGenres();


            ViewBag.DirectorId = DropDownFormatter.FormatDirectors();

            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movieToCreate)
        {
            try
            {
                BlockBusterAdminFunctions.AddMovie(movieToCreate);
                return RedirectToAction("Movie", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.GenreId = DropDownFormatter.FormatGenres();


            ViewBag.DirectorId = DropDownFormatter.FormatDirectors();

            var movie = BlockBusterBasicFunctions.GetMovieByIdFull(id);

            return View(movie);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                BlockBusterAdminFunctions.EditMovie(movie);
                return RedirectToAction("Movie", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            var movie = BlockBusterBasicFunctions.GetMovieByIdFull(id);
            return View(movie);
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Movie movie)
        {
            try
            {

                BlockBusterAdminFunctions.DeleteMovie(movie);
                return RedirectToAction("Movie", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
