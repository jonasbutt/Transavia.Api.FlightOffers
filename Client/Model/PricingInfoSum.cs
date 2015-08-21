namespace Transavia.Api.FlightOffers.Client.Model
{
    public class PricingInfoSum
    {
        public decimal TotalPriceAllPassengers { get; set; }

        public decimal TotalPriceOnePassenger { get; set; }

        public decimal BaseFare { get; set; }

        public decimal TaxSurcharge { get; set; }

        public string CurrencyCode { get; set; }

        public string ProductClass { get; set; }
    }
}