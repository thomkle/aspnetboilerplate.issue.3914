using System.Web.Mvc;

namespace Top.Web.Controllers
{
    public class HomeController : TopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}