using System.Web.Mvc;

namespace Boiler.Web.Controllers
{
    public class AboutController : BoilerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}