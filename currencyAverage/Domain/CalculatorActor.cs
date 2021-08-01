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
    class CalculatorActor: ReceiveActor
    {

        public CalculatorActor()
        {

            Receive<MessageObject>( avg =>
            {
                var sender = Context.Parent;
                decimal avgCur = Decimal.Divide((avg.TupleAvg.Item2 * avg.TupleAvg.Item1 + avg.NewValue) ,(avg.TupleAvg.Item1+1));
                Tuple<int, decimal> t = new Tuple<int, decimal>(avg.TupleAvg.Item1 + 1, avgCur);
                RootObject ro = new RootObject(t);
                sender.Tell(ro);

            });
        }
    }
}
