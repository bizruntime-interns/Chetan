using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class NorthwindController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        // GET: Northwind
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            db.productsTable.ToList();
            return View();
        }
    }
}