using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBook.Data;
using MVCBook.Models;

namespace MVCBook.Controllers
{
    public class MVCBookController : Controller
    {
        private BookDBContext context = new BookDBContext();

        // GET: MVCBook
        public ActionResult Index()
        {
            var books = context.Books.ToList();

            return View("Index", books);
           
        }

        public ActionResult Create()
        {
            Book book = new Book();

            return View("Create", book);
        }

        //Book/Create --> POST
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", book);
        }
    }
}