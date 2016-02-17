using demo_ioc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_ioc.Filters {
    public class RepoIoC :ActionFilterAttribute{
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            ((AnyController)filterContext.Controller).Repo = new Models.Repository();
        }
    }
}