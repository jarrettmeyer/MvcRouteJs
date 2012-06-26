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
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            return Json(new { version }, JsonRequestBehavior.AllowGet);            
        }
    }
}
