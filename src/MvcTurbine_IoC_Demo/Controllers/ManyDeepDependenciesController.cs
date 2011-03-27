using System.Diagnostics;
using System.Web.Mvc;
using MvcTurbine.ComponentModel;

namespace MvcTurbine_IoC_Demo.Controllers
{
    public class ManyDeepDependenciesController : Controller
    {
        public ManyDeepDependenciesController(IPepe pepe, IBigJohn bigJohn, ITotallyTuna totallyTuna, ITurkeyTom turkeyTom, IVito vito, IVegetarian vegetarian, IJjblt jjblt)
        {
        }

        public ActionResult Index()
        {
            var locator = ServiceLocatorManager.Current;
            var limit = 1000;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var index = 0; index < limit; index++)
                locator.Resolve<ManyDeepDependenciesController>();
            stopwatch.Stop();

            var name = locator.GetType().Name.Replace("ServiceLocator", "");
            ViewBag.Message = string.Format("Creating {0} instances with {2} took {1} milliseconds.", limit, stopwatch.ElapsedMilliseconds, name);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}