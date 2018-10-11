using System.Web.Mvc;

namespace Bottom.Web.Controllers
{
    public class AboutController : BottomControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}