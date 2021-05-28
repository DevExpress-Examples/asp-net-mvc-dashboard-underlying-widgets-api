using System.Web;
using System.Web.Mvc;

namespace AspNetMvcDashboardApp {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}