using currencyAverage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace currencyAverage.Services
{
    class HttpClientFactoryService : IHttpClientServiceImplementation
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;
        public HttpClientFactoryService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task Execute()
        {
            throw new NotImplementedException();
        }
        private async Task<Response> GetLastData()
        {

            var client = _httpClientFactory.CreateClient();

            using (var streamTask = await client.GetStreamAsync("https://api.twelvedata.com/time_series?symbol=AAPL,MSFT,EUR/USD,SBUX,NKE&interval=1min&apikey=demo&source=docs"))
            {
                return await System.Text.Json.JsonSerializer.DeserializeAsync<Response>(streamTask);
            }
        }

        Task IHttpClientServiceImplementation.GetLastData()
        {
            throw new NotImplementedException();
        }
    }
}
