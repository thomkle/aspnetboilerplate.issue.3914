using System.Web.Mvc;

namespace Top.Web.Controllers
{
    public class AboutController : TopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}