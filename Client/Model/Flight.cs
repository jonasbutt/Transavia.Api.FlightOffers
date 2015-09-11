using System;

namespace Transavia.Api.FlightOffers.Client.Model
{
    public class Flight
    {
        /// <summary>
        /// The flight ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Scheduled departure date/time based on local time of departure airport.
        /// </summary>
        public DateTime DepartureDateTime { get; set; }

        /// <summary>
        /// Scheduled arrival date/time based on local time of arrival airport.
        /// </summary>
        public DateTime ArrivalDateTime { get; set; }

        /// <summary>
        /// Company short name of the operating carrier.
        /// </summary>
        public MarketingAirline MarketingAirline { get; set; }

        /// <summary>
        /// The flight number as assigned by the operating carrier.
        /// </summary>
        public int FlightNumber { get; set; }

        /// <summary>
        /// IATA location code of destination airport.
        /// </summary>
        public Airport DepartureAirport { get; set; }

        /// <summary>
        /// IATA location code of via airport. This value is null if not applicable.
        /// </summary>
        public Airport ArrivalAirport { get; set; }

        /// <summary>
        /// IATA location code of arrival airport.
        /// </summary>
        public Airport ViaAirport { get; set; }
    }
}