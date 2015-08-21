using System;

namespace Transavia.Api.FlightOffers.Client
{
    public class ApiConnection : IApiConnection
    {
        public Uri Url { get; set; }

        public ApiVersion Version { get; set; }

        public string Key { get; set; }
    }
}