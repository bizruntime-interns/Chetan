using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login.Models;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind] Ad_login user)
        {
            int res = dbop.LoginCheck(user);
            if (res == 1)
            {
                TempData["msg"] = "You are welcome";
            }
            else
            {
                TempData["msg"] = "User id and password is wrong";
            }
            return View();
        }
        

        public IActionResult About()
        {
            TempData["msg"] = "Your application description page";
            return View();
        }

        public IActionResult Contact()
        {
            TempData["msg"] = "Your contact page";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
