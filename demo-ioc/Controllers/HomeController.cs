using demo_ioc.Filters;
using demo_ioc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace demo_ioc.Controllers
{
    public class HomeController : AnyController
    {
       /// <summary>
       /// this is just the index method that sends out the view , not much complexity with the method
       /// </summary>
       /// <returns></returns>
       
        [RepoIoC]
        public async Task< ActionResult> Index()
        {
            List<Skill> result = (await Repo.getSkills("Technical")).ToList<Skill>();
            return View(result);
        }

    }
}
