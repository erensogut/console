

using System.Text.Json.Serialization;

namespace currencyAverage.Domain.Entities
{
    public class Response
    {
        [JsonPropertyName("AAPL")]
        public AAPL Aapl { get; set; }

        [JsonPropertyName("MSFT")]
        public MFST Mfst { get; set; }

        [JsonPropertyName("EUR/USD")]
        public EURUSD Eurusd { get; set; }

        [JsonPropertyName("SBUX")]
        public SBUX Sbux { get; set; }

        [JsonPropertyName("NKE")]
        public NKE Nke { get; set; }

    }
}
