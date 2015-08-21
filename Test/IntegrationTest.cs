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
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508" };

            // Act
            var flightOffersClient = FlightOffersClientFactory.CreateFlightOffersClient();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);

            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
        }

        [TestMethod]
        public async Task CanGetFlightOffersAsyncViaIoc()
        {
            // Arrange
            const string apiKey = "YOUR_API_KEY";
            var request = new FlightOfferRequest { Origin = "AMS", OriginDepartureDate = "201508" };

            // Act
            var container = IocHelper.GetContainerForAssembly(typeof(IFlightOffersClient).Assembly);
            var flightOffersClient = container.GetInstance<IFlightOffersClient>();
            var flightOfferResponse = await flightOffersClient.GetFlightOffersAsync(apiKey, request);

            // Assert
            flightOfferResponse.ShouldNotBeNull();
            flightOfferResponse.FlightOffer.ShouldNotBeEmpty();
        }
    }
}