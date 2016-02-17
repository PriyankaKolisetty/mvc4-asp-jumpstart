using demo_ioc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_ioc.Controllers
{
    public class AnyController : Controller
    {
        public Repository Repo { get; set; }
    }
}
