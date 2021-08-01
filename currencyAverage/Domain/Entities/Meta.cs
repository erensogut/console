using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace currencyAverage.Domain.Entities
{
    public class Meta
    {
        [JsonPropertyName("symbol")] 
        public string symbol { get; set; }

        [JsonPropertyName("interval")] 
        public string interval { get; set; }

        [JsonPropertyName("currency")] 
        public string currency { get; set; }

        [JsonPropertyName("exchange_timezone")] 
        public string exchange_timezone { get; set; }

        [JsonPropertyName("exchange")] 
        public string exchange { get; set; }

        [JsonPropertyName("type")] 
        public string type { get; set; }
    }
}
