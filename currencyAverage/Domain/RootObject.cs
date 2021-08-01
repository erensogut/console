using currencyAverage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyAverage.Domain
{
    class RootObject
    {
        public RootObject(Tuple<int,decimal> tupleAvg)
        {
            //Value = value;
            TupleAvg = tupleAvg;
        }
        //public Value Value { get;  set; }
        public Tuple<int, decimal> TupleAvg { get;  set; }
    }
}
