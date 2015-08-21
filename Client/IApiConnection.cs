using System;

namespace Transavia.Api.FlightOffers.Client
{
    public interface IApiConnection
    {
        Uri Url { get; set; }

        ApiVersion Version { get; set; }

        string Key { get; set; }
    }
}