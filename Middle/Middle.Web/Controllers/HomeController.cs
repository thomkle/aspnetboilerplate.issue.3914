using System.Web.Mvc;

namespace Middle.Web.Controllers
{
    public class HomeController : MiddleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}