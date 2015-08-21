using SimpleInjector;
using System.Linq;
using System.Reflection;

namespace Transavia.Api.FlightOffers.Test
{
    public class IocHelper
    {
        public static Container GetContainerForAssembly(Assembly assembly)
        {
            var container = new Container();
            foreach (var type in assembly.GetExportedTypes())
            {
                var interfaceTypes = type.GetInterfaces();
                if (interfaceTypes.Count() != 1)
                {
                    continue;
                }

                container.Register(interfaceTypes.First(), type);
            }
            return container;
        }
    }
}