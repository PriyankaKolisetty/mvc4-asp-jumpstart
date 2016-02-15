using empty_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace empty_demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Greeting = "We are hostign this rave party @ 6th Avenue , riverside. Get your own hashish!";

            return View();
        }
        [HttpGet]
        public ActionResult RegisterMe() {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterMe(GuestResponse gr) {
            //this guest response can then be appended to the database
            if (ModelState.IsValid ==true) {
                return View("Thanks", gr);
            }
            else {
                return View();
            }
        }
    }
}
