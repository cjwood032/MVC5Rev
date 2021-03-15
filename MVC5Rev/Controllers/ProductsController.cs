using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Rev.Models;

namespace MVC5Rev.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string search="")
        {
            ViewBag.search = search;
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            List<Product> products = db.Products.Where(p=>p.ProductName.Contains(search)).ToList();
            return View(products);
        }
        public ActionResult Details( long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product product = db.Products.Where(p => p.ProductID == id).FirstOrDefault();
            return View(product);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}