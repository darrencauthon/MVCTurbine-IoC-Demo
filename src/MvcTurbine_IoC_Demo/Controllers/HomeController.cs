using System.Diagnostics;
using System.Web.Mvc;
using MvcTurbine.ComponentModel;

namespace MvcTurbine_IoC_Demo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IPepe pepe, IBigJohn bigJohn, ITotallyTuna totallyTuna, ITurkeyTom turkeyTom, IVito vito, IVegetarian vegetarian, IJjblt jjblt)
        {
        }

        public ActionResult Index()
        {
            var locator = ServiceLocatorManager.Current;
            var limit = 1000;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var index = 0; index < limit; index++)
                locator.Resolve<HomeController>();
            stopwatch.Stop();

            ViewBag.Message = string.Format("Creating {0} instances took {1}.", limit, stopwatch.ElapsedMilliseconds);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}