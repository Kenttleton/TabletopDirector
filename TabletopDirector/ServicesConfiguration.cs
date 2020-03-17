using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TabletopDirector.Auth;
using TabletopDirector.DataAccess;

namespace TabletopDirector
{
    public static class ServicesConfiguration
    {
        public static void AddTabletopDirector(this IServiceCollection services, ILoggerFactory? loggerFactory = null)
        {
            if(loggerFactory != null)
            {
                services.AddDataAccess(loggerFactory);
            }
            else
            {
                services.AddDataAccess();
            }
            services.AddTDAuthentication();
        }
    }
}
