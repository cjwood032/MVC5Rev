using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Rev.Models;

namespace MVC5Rev.Controllers
{
    public class CategoriesController : Controller
    {
        CompanyDbContext db = new CompanyDbContext();
        // GET: Categories
        public ActionResult Index()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
    }
}