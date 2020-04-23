using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirst.Models;

namespace DbFirst.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindDbEntities db = new NorthwindDbEntities();
        // GET: Categories
        public ActionResult Index()
        {
            return View(db.tblCategories.ToList());
        }
    }
}