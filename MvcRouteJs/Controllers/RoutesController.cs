using System.Web.Mvc;
using MvcRouteJs.Models;

namespace MvcRouteJs.Controllers
{
    public class RoutesController : Controller
    {
        private static bool hasInitializedRoutes = false;
        private static Routes routes;

        public ActionResult Index()
        {
            // We will probably want to cache this output result. It isn't going to 
            // change during the application lifecycle. It will be much faster to
            // return 304's than 200's.
            InitializeRoutes();
            return JavaScript(routes.ToString());            
        }

        private void InitializeRoutes()
        {
            // This won't change during an application's lifetime. We can make the routes
            // variable static, along with the initialization check. We cannot make the 
            // entire method static (nor can we use a static constructor), since the UrlHelper
            // instance (this.Url) is not static.
            if (!hasInitializedRoutes)
            {
                routes = new Routes();
                routes.Add("about_url", Url.Action("About", "Home"));
                routes.Add("home_url", Url.Action("Index", "Home"));
                routes.Add("version_url", Url.Action("Version", "Home"));
                hasInitializedRoutes = true;
            }
        }
    }
}
