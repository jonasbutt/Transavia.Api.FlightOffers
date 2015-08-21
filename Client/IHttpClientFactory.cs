using System.Net.Http;

namespace Transavia.Api.FlightOffers.Client
{
    public interface IHttpClientFactory
    {
        HttpClient CreateHttpClient(string apiKey);
    }
}