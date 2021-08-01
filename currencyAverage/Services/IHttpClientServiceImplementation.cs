using System.Threading.Tasks;

namespace currencyAverage
{
    internal interface IHttpClientServiceImplementation
    {
        public  Task GetLastData();

    }
}