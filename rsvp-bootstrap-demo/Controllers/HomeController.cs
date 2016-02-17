using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rsvp_bootstrap_demo.Models;

namespace rsvp_bootstrap_demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register() {
            return View();
        }
        [HttpPost]
        public ActionResult Register(GuestResponse gr) {
            ViewBag.IsComing = gr.IsAvailable;
            return View("Thanks");
        }
    }
}
