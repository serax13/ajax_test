using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BookSearch(string name)
        {
            var allbooks = db.Books.Where(a => a.Author.Contains(name)).ToList();
            return PartialView(allbooks);
        }

        public ActionResult BestBook()
        {
            Book book = db.Books.First();
            return PartialView(book);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}