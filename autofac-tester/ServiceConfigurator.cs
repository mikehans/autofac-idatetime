using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace autofac_tester
{
    internal static class ServiceConfigurator
    {
        internal static IServiceProvider ConfigureStorage()
        {
            var sc = new ServiceCollection();

            ContainerBuilder cb = new ContainerBuilder();

            cb.Populate(sc);

            IContainer container = cb.Build();
            return new AutofacServiceProvider(container);
        }
    }
}
