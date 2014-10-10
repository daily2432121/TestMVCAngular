using System.Web.Mvc;

namespace TestMVCAngular.Web.Controllers
{
    public class HomeController : TestMVCAngularControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}