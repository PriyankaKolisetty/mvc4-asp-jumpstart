using System.Web;
using System.Web.Mvc;

namespace rsvp_bootstrap_demo {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}