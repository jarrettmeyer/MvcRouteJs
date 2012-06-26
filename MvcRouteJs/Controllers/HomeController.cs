using System.Web.Mvc;

namespace MvcRouteJs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Version()
        {
            return PartialView("_Version");
        }
    }
}
