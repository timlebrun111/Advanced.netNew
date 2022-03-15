using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Library.Models;
using BookstoreWebApp.Helpers;
using BookStore.Library;

namespace BookstoreWebApp.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = BookStoreFunctions.GetBookByIdFull(id);
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = DropDownFormatter.FormatGenres();

            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();

            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book bookToCreate)
        {
            try
            {
                BookStoreAdminFunctions.AddBook(bookToCreate);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.GenreId = DropDownFormatter.FormatGenres();

            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();

            var book = BookStoreFunctions.GetBookByIdFull(id);

            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            try
            {
                BookStoreAdminFunctions.EditBook(book);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = BookStoreFunctions.GetBookByIdFull(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Book book)
        {
            try
            {
                BookStoreAdminFunctions.DeleteBook(book);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
