using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TabletopDirector.Rules
{
    public static class RuleSetRegister
    {
        public static void RegisterServicesFromAssembly<T>(this IServiceCollection services)
        {
            var injectableTypes = typeof(T).Assembly.DefinedTypes
                .Where(x => x.GetCustomAttributes(typeof(RuleSetAttribute), false).FirstOrDefault() != null && x.IsClass);

            foreach (var injectableType in injectableTypes)
            {
                var injectAttributeData = injectableType
                    .GetCustomAttributes(typeof(RuleSetAttribute), false).First() as RuleSetAttribute;

                if (injectAttributeData.ExplicitInterface != null)
                {
                    services.Add(new ServiceDescriptor(
                        injectAttributeData.ExplicitInterface,
                        injectableType,
                        injectAttributeData.ServiceLifetime));
                }
                else
                {
                    foreach (var implementedInterface in injectableType.ImplementedInterfaces)
                    {
                        services.Add(new ServiceDescriptor(
                            implementedInterface,
                            injectableType,
                            injectAttributeData.ServiceLifetime));
                    }
                }
            }
        }
    }
}
