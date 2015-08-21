using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Transavia.Api.FlightOffers.Client
{
    public class SerializationHelper : ISerializationHelper
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });
        }

        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public string SerializeToQueryString(object data)
        {
            var stringBuilder = new StringBuilder();
            var properties = data.GetType().GetRuntimeProperties();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var properyValue = property.GetValue(data);
                if (properyValue != null)
                {
                    stringBuilder.AppendFormat("{0}={1}&", propertyName, properyValue);
                }
            }
            return stringBuilder.ToString().TrimEnd('&');            
        }
    }
}