using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace currencyAverage.Domain.Entities
{
    public class Value
    {

        [JsonPropertyName("datetime")] 
        public string datetime { get; set; }
        [JsonPropertyName("open")] 
        public string open { get; set; }
        [JsonPropertyName("high")] 
        public string high { get; set; }
        [JsonPropertyName("low")] 
        public string low { get; set; }
        [JsonPropertyName("close")] 
        public string close { get; set; }
        [JsonPropertyName("volume")] 
        public string volume { get; set; }
    }
}
