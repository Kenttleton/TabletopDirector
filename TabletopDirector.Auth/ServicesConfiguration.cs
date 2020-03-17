using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.Auth
{
    public static class ServicesConfiguration
    {
        public static void AddTDAuthentication(this IServiceCollection services, ILoggerFactory? loggerFactory = null)
        {
            services.AddAuthenticationCore(options =>
            {
                //options.AddScheme();
            });
        }
    }
}
