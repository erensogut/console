using Akka.Actor;
using currencyAverage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace currencyAverage.Domain
{
    class RootActor: ReceiveActor
    {
        private static readonly HttpClient client = new HttpClient();

        //private static readonly IHttpClientServiceImplementation client;

        public RootActor()
        {
            Tuple<int, decimal> t = new Tuple<int, decimal>(0, 0);

            Receive<RootObject>(async greet =>
            {
                
                t = greet.TupleAvg;
                Console.WriteLine("Your current avg " + t.Item2);

            });
            Receive<int>(async val =>
            {
                IActorRef child = Context.ActorOf<CalculatorActor>();
                var streamTask = client.GetStreamAsync("https://api.twelvedata.com/time_series?symbol=AAPL,MSFT,EUR/USD,SBUX,NKE&interval=1min&apikey=demo&source=docs");
                var responses = await System.Text.Json.JsonSerializer.DeserializeAsync<Response>(await streamTask);
                //var responses =  client.GetLastData();

                MessageObject mo = new MessageObject(t, decimal.Parse(responses.Aapl.values[0].close, System.Globalization.CultureInfo.InvariantCulture));
                child.Tell(mo);
            });
        }
    }
}
