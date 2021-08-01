using currencyAverage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyAverage.Domain
{
    class MessageObject
    {
        public MessageObject(Tuple<int,decimal> tupleAvg, decimal newValue)
        {
            TupleAvg = tupleAvg;
            NewValue = newValue;
        }
        public Tuple<int, decimal> TupleAvg { get;  set; }

        public decimal NewValue { get; set; }
    }
}
