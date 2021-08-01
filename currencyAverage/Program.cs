using Akka.Actor;
using currencyAverage.Domain;
using currencyAverage.Domain.Entities;
using currencyAverage.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Xml;

namespace currencyAverage
{
    class Program
    {


        static System.Threading.Tasks.Task Main(string[] args)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);


            var system = ActorSystem.Create("MySystem");

            
            var starter = system.ActorOf<RootActor>("greeter");
            //greeter.Tell(new RootObject(repositories.Aapl.values[0]));

            system.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(0),TimeSpan.FromSeconds(60), starter, 1, ActorRefs.NoSender); 
            Console.Read();
            Console.WriteLine("Hello World!");
            return System.Threading.Tasks.Task.CompletedTask;
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddSingleton<IHttpClientServiceImplementation, AkkaService>();
        }
    }
}
