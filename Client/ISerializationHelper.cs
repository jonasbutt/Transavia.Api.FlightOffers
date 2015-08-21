namespace Transavia.Api.FlightOffers.Client
{
    public interface ISerializationHelper
    {
        T Deserialize<T>(string json);

        string Serialize(object data);

        string SerializeToQueryString(object data);
    }
}