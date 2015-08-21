using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Transavia.Api.FlightOffers.Client
{
    public class HttpService : IHttpService
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly ISerializationHelper serializationHelper;

        public HttpService(
            ISerializationHelper serializationHelper, 
            IHttpClientFactory httpClientFactory)
        {
            this.serializationHelper = serializationHelper;
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<T> GetAsync<T>(IApiConnection apiConnection, string resource)
        {
            var requestUrl = string.Format("{0}/{1}/{2}",
                apiConnection.Url,
                apiConnection.Version.ToString().ToLowerInvariant(),
                resource);
            var httpClient = this.httpClientFactory.CreateHttpClient(apiConnection.Key);
            var json = await httpClient.GetStringAsync(requestUrl);
            return this.serializationHelper.Deserialize<T>(json);
        }

        public async Task<T> GetAsync<T>(IApiConnection apiConnection, string resource, object data)
        {
            var queryString = this.serializationHelper.SerializeToQueryString(data);
            var requestUrl = string.Format("{0}/{1}/{2}?{3}",
                apiConnection.Url,
                apiConnection.Version.ToString().ToLowerInvariant(),
                resource,
                queryString);
            var httpClient = this.httpClientFactory.CreateHttpClient(apiConnection.Key);
            var json = await httpClient.GetStringAsync(requestUrl);
            return this.serializationHelper.Deserialize<T>(json);
        }

        public async Task<T> PostAsync<T>(IApiConnection apiConnection, string resource, object data)
        {
            var requestUrl = string.Format("{0}/{1}/{2}",
                apiConnection.Url,
                apiConnection.Version.ToString().ToLowerInvariant(),
                resource);
            var httpClient = this.httpClientFactory.CreateHttpClient(apiConnection.Key);
            var dataAsJson = this.serializationHelper.Serialize(data);
            var requestContent = new StringContent(dataAsJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(requestUrl, requestContent);
            var json = await response.Content.ReadAsStringAsync();
            return this.serializationHelper.Deserialize<T>(json);
        }
    }
}