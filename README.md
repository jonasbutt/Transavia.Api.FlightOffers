# Transavia Flight Offers API Client for .NET  
Get NuGet package: https://www.nuget.org/packages/Transavia.Api.FlightOffers  
More info: https://developer.transavia.com  
Disclaimer: this project is not created by Transavia!  
Example usage:  
```c#
var request = new FlightOfferRequest 
  { 
    Origin = "AMS",  
    OriginDepartureDate = "201508",  
    Limit = 5   
  };
var client = FlightOffersClientFactory.CreateFlightOffersClient();
var flightOfferResponse = await client.GetFlightOffersAsync("YOUR_API_KEY", request);
```
