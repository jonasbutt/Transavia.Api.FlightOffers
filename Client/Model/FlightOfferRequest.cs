namespace Transavia.Api.FlightOffers.Client.Model
{
    public class FlightOfferRequest
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public string OriginDepartureDate { get; set; }

        public string DestinationArrivalDate { get; set; }

        public string DestinationDepartureDate { get; set; }

        public string OriginArrivalDate { get; set; }

        public string OriginDepartureTime { get; set; }

        public string DestinationArrivalTime { get; set; }

        public string DestinationDepartureTime { get; set; }

        public string OriginArrivalTime { get; set; }

        public string OriginDepartureDayOfWeek { get; set; }

        public string DestinationArrivalDayOfWeek { get; set; }

        public string DestinationDepartureDayOfWeek { get; set; }

        public string OriginArrivalDayOfWeek { get; set; }

        public int? TripDuration { get; set; }

        public int? Adults { get; set; }

        public int? Children { get; set; }

        public string Price { get; set; }

        public bool? GroupPricing { get; set; }

        public string ProductClass { get; set; }

        public bool? DirectFlight { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public string OrderBy { get; set; }
    }
}