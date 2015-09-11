namespace Transavia.Api.FlightOffers.Client.Model
{
    public class PricingInfoSum
    {
        /// <summary>
        /// The total amount for all passengers.
        /// </summary>
        public decimal TotalPriceAllPassengers { get; set; }

        /// <summary>
        /// The total amount for one passenger.
        /// </summary>
        public decimal TotalPriceOnePassenger { get; set; }

        /// <summary>
        /// The amount of the base fare.
        /// </summary>
        public decimal BaseFare { get; set; }

        /// <summary>
        /// The amount of the tax surcharge.
        /// </summary>
        public decimal TaxSurcharge { get; set; }

        /// <summary>
        /// Currency code of the included amounts. Default value is "EUR".
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The branded fares product class.
        /// </summary>
        public string ProductClass { get; set; }
    }
}