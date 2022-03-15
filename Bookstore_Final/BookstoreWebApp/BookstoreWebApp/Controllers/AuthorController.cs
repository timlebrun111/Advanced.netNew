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
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author authorToCreate)
        {
            try
            {
                BookStoreAdminFunctions.AddAuthor(authorToCreate);
                return RedirectToAction("Author", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            var author = BookStoreFunctions.GetAuthorByIdFull(id);

            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author author)
        {
            try
            {
                BookStoreAdminFunctions.EditAuthor(author);
                return RedirectToAction("Author", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = BookStoreFunctions.GetAuthorByIdFull(id);

            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author author)
        {
            try
            {

                BookStoreAdminFunctions.DeleteAuthor(author);
                return RedirectToAction("Author", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
