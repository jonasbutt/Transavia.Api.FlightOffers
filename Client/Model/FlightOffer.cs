namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOffer
    {
        public Flight OutboundFlight { get; set; }

        public Flight InboundFlight { get; set; }

        public PricingInfoSum PricingInfoSum { get; set; }

        public Link Deeplink { get; set; }
    }
}