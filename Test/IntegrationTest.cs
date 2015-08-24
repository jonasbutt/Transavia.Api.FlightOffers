using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using Transavia.Api.FlightOffers.Client;
using Transavia.Api.FlightOffers.Client.Model;

namespace Transavia.Api.FlightOffers.Test
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public async Task CanGetFlightOffersAsync()
        {
            // Arrange
            const string apiKey = "YOUR_API_KEY";
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508", Limit = 5 };

            // Act
            var flightOffersClient = FlightOffersClientFactory.CreateFlightOffersClient();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);

            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
            AssertValidFlightOffers(flightOfferResponse.FlightOffer);
        }

        [TestMethod]
        public async Task CanGetFlightOffersAsyncViaIoc()
        {
            // Arrange
            const string apiKey = "YOUR_API_KEY";
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508", Limit = 5 };

            // Act
            var container = IocHelper.GetContainerForAssembly(typeof(IFlightOffersClient).Assembly);
            var flightOffersClient = container.GetInstance<IFlightOffersClient>();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);

            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
            AssertValidFlightOffers(flightOfferResponse.FlightOffer);
        }

        [TestMethod]
        public async Task CanGetFlightOffersDirectOnlyAsync()
        {
            // Arrange
            const string apiKey = "YOUR_API_KEY";
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508", DirectFlight = true, Limit = 5 };

            // Act
            var flightOffersClient = FlightOffersClientFactory.CreateFlightOffersClient();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);
            
            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
            AssertValidFlightOffers(flightOfferResponse.FlightOffer);

            var hasOnlyDirectFlights = flightOfferResponse.FlightOffer.All(f => f.OutboundFlight.ViaAirport == null);
            hasOnlyDirectFlights.ShouldBeTrue();
        }

        [TestMethod]
        public async Task CanGetFlightOffersForReturnFlightsAsync()
        {
            // Arrange
            const string apiKey = "YOUR_API_KEY";
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508", DestinationDepartureDate = "201509", Limit = 5 };

            // Act
            var flightOffersClient = FlightOffersClientFactory.CreateFlightOffersClient();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);

            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
            AssertValidFlightOffers(flightOfferResponse.FlightOffer);

            var hasOnlyReturnFlights = flightOfferResponse.FlightOffer.All(f => f.InboundFlight != null);
            hasOnlyReturnFlights.ShouldBeTrue();
        }

        private static void AssertValidFlightOffers(IEnumerable<FlightOffer> flightOffers)
        {
            foreach (var flightOffer in flightOffers)
            {
                flightOffer.Deeplink.ShouldNotBeNull();
                string.IsNullOrEmpty(flightOffer.Deeplink.Href).ShouldBeFalse();

                flightOffer.PricingInfoSum.ShouldNotBeNull();
                string.IsNullOrEmpty(flightOffer.PricingInfoSum.ProductClass).ShouldBeFalse();
                string.IsNullOrEmpty(flightOffer.PricingInfoSum.CurrencyCode).ShouldBeFalse();
                flightOffer.PricingInfoSum.BaseFare.ShouldBeGreaterThan(0);
                flightOffer.PricingInfoSum.TaxSurcharge.ShouldBeGreaterThan(0);
                flightOffer.PricingInfoSum.TotalPriceOnePassenger.ShouldBeGreaterThan(0);
                flightOffer.PricingInfoSum.TotalPriceOnePassenger.ShouldBeGreaterThan(0);

                flightOffer.OutboundFlight.ShouldNotBeNull();
                AssertValidFlight(flightOffer.OutboundFlight);
                if (flightOffer.InboundFlight != null)
                {
                    AssertValidFlight(flightOffer.InboundFlight);
                }
            }
        }

        private static void AssertValidFlight(Flight flight)
        {
            string.IsNullOrEmpty(flight.Id).ShouldBeFalse();
            flight.FlightNumber.ShouldBeGreaterThan(0);
            flight.DepartureAirport.ShouldNotBeNull();
            string.IsNullOrEmpty(flight.DepartureAirport.LocationCode).ShouldBeFalse();
            flight.ArrivalAirport.ShouldNotBeNull();
            string.IsNullOrEmpty(flight.ArrivalAirport.LocationCode).ShouldBeFalse();
            flight.MarketingAirline.ShouldNotBeNull();
            string.IsNullOrEmpty(flight.MarketingAirline.CompanyShortName).ShouldBeFalse();
            if (flight.ViaAirport != null)
            {
                string.IsNullOrEmpty(flight.ViaAirport.LocationCode).ShouldBeFalse();
            }
        }
    }
}