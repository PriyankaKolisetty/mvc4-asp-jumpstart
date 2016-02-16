using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            AppUser user = new AppUser() { alias = "asdsdsdf", email = "dsfdsf", empno = 41993 };
            ViewBag.Greeting = "This is hello from inside the HomeController";

            return View(user);
        }

    }
}
