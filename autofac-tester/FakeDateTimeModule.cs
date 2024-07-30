using AF.DateTime;
using Autofac;
using System;
using System.Linq;

namespace autofac_tester
{
    class FakeDateTimeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FakeDateTime>().As<IDateTime>().SingleInstance();
        }
    }
}
