using System.Collections.Generic;

namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOfferResponse
    {
        /// <summary>
        /// Info about the result.
        /// </summary>
        public ResultSet ResultSet { get; set; }

        /// <summary>
        /// Flight offers.
        /// </summary>
        public List<FlightOffer> FlightOffer { get; set; }
    }
}