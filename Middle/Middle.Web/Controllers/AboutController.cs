using System.Web.Mvc;

namespace Middle.Web.Controllers
{
    public class AboutController : MiddleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}