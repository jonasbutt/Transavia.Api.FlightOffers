using System.Collections.Generic;

namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOfferResponse
    {
        public ResultSet ResultSet { get; set; }

        public List<FlightOffer> FlightOffer { get; set; }
    }
}