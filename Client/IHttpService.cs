using System.Threading.Tasks;

namespace Transavia.Api.FlightOffers.Client
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(IApiConnection apiConnection, string resource);

        Task<T> GetAsync<T>(IApiConnection apiConnection, string resource, object data);

        Task<T> PostAsync<T>(IApiConnection apiConnection, string resource, object data);
    }
}