using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var httpApps = HttpContext.ApplicationInstance;
            ViewBag.Modules = httpApps.Modules.AllKeys;
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}