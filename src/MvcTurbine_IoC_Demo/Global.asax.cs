using MvcTurbine.ComponentModel;
using MvcTurbine.Hiro;
using MvcTurbine.Ninject;
using MvcTurbine.StructureMap;
using MvcTurbine.Unity;
using MvcTurbine.Web;
using MvcTurbine.Windsor;

namespace MvcTurbine_IoC_Demo
{
    public class MvcApplication : TurbineApplication
    {
        public MvcApplication()
        {
            //ServiceLocatorManager.SetLocatorProvider(() => new HiroServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new UnityServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new StructureMapServiceLocator());
            //ServiceLocatorManager.SetLocatorProvider(() => new WindsorServiceLocator());
            ServiceLocatorManager.SetLocatorProvider(() => new NinjectServiceLocator());
        }
    }
}