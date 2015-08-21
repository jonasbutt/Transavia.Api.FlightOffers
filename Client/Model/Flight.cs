using System;

namespace Transavia.Api.FlightOffers.Client.Model
{
    public class Flight
    {
        public string Id { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArrivalDateTime { get; set; }

        public MarketingAirline MarketingAirline { get; set; }

        public int FlightNumber { get; set; }

        public Airport DepartureAirport { get; set; }

        public Airport ArrivalAirport { get; set; }

        public Airport ViaAirport { get; set; }
    }
}