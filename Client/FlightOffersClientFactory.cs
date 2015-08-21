namespace Transavia.Api.FlightOffers.Client
{
    public class FlightOffersClientFactory
    {
        public static IFlightOffersClient CreateFlightOffersClient()
        {
            return new FlightOffersClient(new HttpService(new SerializationHelper(), new HttpClientFactory()));
        }
    }
}