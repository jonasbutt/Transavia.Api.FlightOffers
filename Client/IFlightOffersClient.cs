using System.Threading.Tasks;
using Transavia.Api.FlightOffers.Client.Model;

namespace Transavia.Api.FlightOffers.Client
{
    public interface IFlightOffersClient
    {
        Task<FlightOfferResponse> GetFlightOffersAsync(IApiConnection apiConnection, FlightOfferRequest request);

        Task<FlightOfferResponse> GetFlightOffersAsync(string apiKey, FlightOfferRequest request);
    }
}