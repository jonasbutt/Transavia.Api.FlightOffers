namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOfferRequest
    {
        /// <summary>
        /// Requested route key (single or multiple) of Origin; based on IATA-code.
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Requested route key (single or multiple) of Destination; based on IATA-code.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Date / Range to depart from origin airport. Must be in format yyyyMMdd or yyyyMM.
        /// </summary>
        public string OriginDepartureDate { get; set; }

        /// <summary>
        /// Date / Range to arrive on destination airport. Must be in format yyyyMMdd or yyyyMM.
        /// </summary>
        public string DestinationArrivalDate { get; set; }

        /// <summary>
        /// Date / Range to depart from destination airport. Must be in format yyyyMMdd or yyyyMM.
        /// </summary>
        public string DestinationDepartureDate { get; set; }

        /// <summary>
        /// Date / Range to arrive on origin airport. Must be in format yyyyMMdd or yyyyMM.
        /// </summary>
        public string OriginArrivalDate { get; set; }

        /// <summary>
        /// Time range in which to depart from origin airport. Must be in format (0000-2359).
        /// </summary>
        public string OriginDepartureTime { get; set; }

        /// <summary>
        /// Time range in which to arrive on destination airport. Must be in format (0000-2359).
        /// </summary>
        public string DestinationArrivalTime { get; set; }

        /// <summary>
        /// Time range in which to depart from destination airport. Must be in format (0000-2359).
        /// </summary>
        public string DestinationDepartureTime { get; set; }

        /// <summary>
        /// Time range in which to arrive on origin airport. Must be in format (0000-2359).
        /// </summary>
        public string OriginArrivalTime { get; set; }

        /// <summary>
        /// Preferred departureday(s) of week to depart from origin airport, comma separated (mo,th,we).
        /// </summary>
        public string OriginDepartureDayOfWeek { get; set; }

        /// <summary>
        /// Preferred departureday(s) of week to arrive on destination airport, comma separated (mo,th,we).
        /// </summary>
        public string DestinationArrivalDayOfWeek { get; set; }

        /// <summary>
        /// Preferred departureday(s) of week to depart from destination airport, comma separated (mo,th,we).
        /// </summary>
        public string DestinationDepartureDayOfWeek { get; set; }

        /// <summary>
        /// Preferred departureday(s) of week to arrive on origin airport, comma separated (mo,th,we).
        /// </summary>
        public string OriginArrivalDayOfWeek { get; set; }

        /// <summary>
        /// Number of days at destination.
        /// </summary>
        public int? TripDuration { get; set; }

        /// <summary>
        /// Number of adult passengers.
        /// </summary>
        public int? Adults { get; set; }

        /// <summary>
        /// Number of child passengers.
        /// </summary>
        public int? Children { get; set; }

        /// <summary>
        /// Price range in EURO for the flight offer (format 50-200).
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Returns price for all passengers.
        /// </summary>
        public bool? GroupPricing { get; set; }

        /// <summary>
        /// Product Class (basic, plus, max) of the Flight Offer (basic = default).
        /// </summary>
        public string ProductClass { get; set; }

        /// <summary>
        /// When set, will only return direct flights.
        /// </summary>
        public bool? DirectFlight { get; set; }

        /// <summary>
        /// Maximum number of items in the response (default = 100, max = 1000 for one-way / 200 for round-trip).
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Paging number of the limited result set.
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Comma-separated list of fields on which the result must be ordered. 
        /// Allowed values: 'Origin', 'Destination', 'OriginDepartureDate', 'DestinationArrivalDate', 'Price'. 
        /// For return flights also the values 'DestinationDepartureDate' and 'OriginArrivalDate' can be used. (default = OriginDepartureDate, Origin, Destination).
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Comma-separated list of 'advanced/optional' fields to be included in the response. 
        /// Allowed values: ClassOfService
        /// </summary>
        public string Include { get; set; }

        /// <summary>
        /// Comma-separated list of elements to be left out of the response. 
        /// Allowed values: FlightSegments, SumOfPricingInfos, PricingInfos.
        /// </summary>
        public string Exclude { get; set; }
    }
}