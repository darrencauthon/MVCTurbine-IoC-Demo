using System.Diagnostics;
using System.Web.Mvc;
using MvcTurbine.ComponentModel;

namespace MvcTurbine_IoC_Demo.Controllers
{
    public class AFewSimpleDependenciesController : Controller
    {
        public AFewSimpleDependenciesController(IMommy mommy, IDaddy daddy, ILawyer lawyer)
        {
        }

        public ActionResult Index()
        {
            var locator = ServiceLocatorManager.Current;
            var limit = 10000;

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (var index = 0; index < limit; index++)
                locator.Resolve<AFewSimpleDependenciesController>();
            stopwatch.Stop();

            ViewBag.Message = string.Format("Creating {0} instances took {1} milliseconds.", limit, stopwatch.ElapsedMilliseconds);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}