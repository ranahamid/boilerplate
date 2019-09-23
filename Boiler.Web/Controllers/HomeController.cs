using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Boiler.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}