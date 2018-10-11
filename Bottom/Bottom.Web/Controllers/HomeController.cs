using System.Web.Mvc;

namespace Bottom.Web.Controllers
{
    public class HomeController : BottomControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}