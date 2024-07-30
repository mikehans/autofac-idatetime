using AF.DateTime;
using AF.DTConsumer;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using autofac_tester;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args)
    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(b =>
    {
        b.RegisterModule(new FakeDateTimeModule());
        b.RegisterModule(new DateTimeModule());

        b.Register(c => new MyConsumer { _dateTime = c.Resolve<IDateTime>() });
        b.RegisterType<AConsumer>();
    })
    .Build();

Console.WriteLine("Using AConsumer class...");
var ac = host.Services.GetRequiredService<AConsumer>();
Console.WriteLine($"AConsumer tomorrow is {ac.GetTomorrow()}");

Console.WriteLine("Now, to use the MyConsumer class...");
MyConsumer me = host.Services.GetRequiredService<MyConsumer>();
Console.WriteLine(me.WriteDTNow());
Console.WriteLine(me.WriteDTNextWeek());


Console.WriteLine("DONE");

await host.RunAsync();