using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace currencyAverage.Domain.Entities
{
    public class EURUSD
    {
        [JsonPropertyName("meta")]
        public Meta meta { get; set; }

        [JsonPropertyName("values")]
        public List<Value> values { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
