using MvcTurbine.ComponentModel;
using MvcTurbine.Hiro;
using MvcTurbine.Web;

namespace MvcTurbine_IoC_Demo
{
    public class MvcApplication : TurbineApplication
    {
        public MvcApplication()
        {
            ServiceLocatorManager.SetLocatorProvider(() => new HiroServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new UnityServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new StructureMapServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new WindsorServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new NinjectServiceLocator());
        }
    }
}