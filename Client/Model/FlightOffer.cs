namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOffer
    {
        /// <summary>
        /// The outbound flight.
        /// </summary>
        public Flight OutboundFlight { get; set; }

        /// <summary>
        /// The inbound flight.
        /// </summary>
        public Flight InboundFlight { get; set; }

        /// <summary>
        /// The pricing information.
        /// </summary>
        public PricingInfoSum PricingInfoSum { get; set; }

        /// <summary>
        /// The URL to the transavia.com website for this route segment and date.
        /// </summary>
        public Link Deeplink { get; set; }
    }
}