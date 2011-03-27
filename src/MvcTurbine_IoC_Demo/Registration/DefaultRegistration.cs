using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvcTurbine.ComponentModel;

namespace MvcTurbine_IoC_Demo.Registration
{
    public class Testing1 : IServiceRegistration
    {
        public void Register(IServiceLocator locator)
        {
            
        }
    }

    public class DefaultRegistration : IServiceRegistration
    {
        private readonly Assembly assembly;

        public DefaultRegistration()
        {
            assembly = typeof (DefaultRegistration).Assembly;
        }

        public void Register(IServiceLocator locator)
        {
            GetPossibleInterfacesToRegister()
                .ForEach(@interface => RegisterThisInterfaceWithASingleImplementer(@interface, locator));
        }

        private void RegisterThisInterfaceWithASingleImplementer(Type @interface, IServiceLocator locator)
        {
            var implementers = GetImplementers(@interface);
            if (ThereIsOnlyOneImplementerOfThisInterface(implementers))
                RegisterTheTwo(@interface, implementers, locator);
        }

        private void RegisterTheTwo(Type @interface, IEnumerable<Type> implementers, IServiceLocator locator)
        {
            locator.Register(@interface, implementers.Single());
        }

        private bool ThereIsOnlyOneImplementerOfThisInterface(IEnumerable<Type> implementers)
        {
            return implementers.Count() == 1;
        }

        private IEnumerable<Type> GetImplementers(Type @interface)
        {
            return assembly.GetTypes().Where(x => x.GetInterfaces().Contains(@interface));
        }

        private List<Type> GetPossibleInterfacesToRegister()
        {
            return assembly
                .GetTypes().Where(x => x.IsInterface)
                .Where(x=>x.Namespace == "MvcTurbine_IoC_Demo")
                .ToList();
        }
    }
}