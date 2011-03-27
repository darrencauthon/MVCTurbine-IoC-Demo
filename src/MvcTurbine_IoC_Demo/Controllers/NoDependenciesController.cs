using System.Diagnostics;
using System.Web.Mvc;
using MvcTurbine.ComponentModel;

namespace MvcTurbine_IoC_Demo.Controllers
{
    public class NoDependenciesController : Controller
    {
        public ActionResult Index()
        {
            var locator = ServiceLocatorManager.Current;
            var limit = 100000;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var index = 0; index < limit; index++)
                locator.Resolve<NoDependenciesController>();
            stopwatch.Stop();

            ViewBag.Message = string.Format("Creating {0} instances took {1}  milliseconds.", limit, stopwatch.ElapsedMilliseconds);

            return View();
        }
    }
}