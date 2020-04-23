using Login_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Page.Controllers
{
    public class HomeController : Controller
    {
        LoginPageEntities3 db = new LoginPageEntities3();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(LoginPage model)
        {
            db.LoginPages.Add(model);
            db.SaveChanges();
            return Json("Registration successful", JsonRequestBehavior.AllowGet);
        }
    }
}