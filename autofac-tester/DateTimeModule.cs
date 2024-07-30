using AF.DateTime;
using Autofac;
using System;
using System.Linq;

namespace autofac_tester
{
    class DateTimeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppDateTime>().As<IDateTime>().SingleInstance();
        }
    }
}
