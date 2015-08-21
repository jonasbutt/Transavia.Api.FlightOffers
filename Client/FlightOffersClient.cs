using System;
using System.Threading.Tasks;
using Transavia.Api.FlightOffers.Client.Model;

namespace Transavia.Api.FlightOffers.Client
{
    public class FlightOffersClient : IFlightOffersClient
    {
        private readonly IHttpService httpService;

        public FlightOffersClient(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<FlightOfferResponse> GetFlightOffersAsync(IApiConnection apiConnection, FlightOfferRequest request)
        {
            return await this.httpService.GetAsync<FlightOfferResponse>(apiConnection, "flightoffers", request);
        }

        public async Task<FlightOfferResponse> GetFlightOffersAsync(string apiKey, FlightOfferRequest request)
        {
            var apiConnection = new ApiConnection
            {
                Url = new Uri("https://api.transavia.com"),
                Version = ApiVersion.V1,
                Key = apiKey
            };

            return await this.httpService.GetAsync<FlightOfferResponse>(apiConnection, "flightoffers", request);
        }
    }
}