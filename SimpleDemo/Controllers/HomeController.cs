using System.Web.Mvc;

namespace SimpleDemo.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
    }
}