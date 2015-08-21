using System.Net.Http;
using System.Net.Http.Headers;

namespace Transavia.Api.FlightOffers.Client
{
    public class HttpClientFactory : IHttpClientFactory
    {
        public HttpClient CreateHttpClient(string apiKey)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("apiKey", apiKey);
            return httpClient;
        }
    }
}