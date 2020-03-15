using Microsoft.Extensions.DependencyInjection;
using System;

namespace TabletopDirector.Rules
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RuleSetAttribute : Attribute
    {
        /// <summary>
        /// Property to determine lifetime of injected type
        /// </summary>
        public ServiceLifetime ServiceLifetime { get; }

        /// <summary>
        /// Assign explicit interface to implement
        /// </summary>
        public Type ExplicitInterface { get; }

        /// <summary>
        /// Assign a rule set name to search on
        /// </summary>
        public string RuleSetName { get; }

        public RuleSetAttribute(string ruleSetName, Type explicitInterface = null, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            ServiceLifetime = serviceLifetime;
            RuleSetName = ruleSetName;

            if (explicitInterface != null && !explicitInterface.IsInterface)
                throw new ArgumentException(nameof(explicitInterface));

            ExplicitInterface = explicitInterface;
        }
    }
}
