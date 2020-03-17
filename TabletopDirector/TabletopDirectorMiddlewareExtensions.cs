using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TabletopDirector.Auth.Middleware;
using TabletopDirector.DataAccess.Middleware;

namespace TabletopDirector
{
    public static class TabletopDirectorMiddlewareExtensions
    {
        public static IApplicationBuilder UseTabletopDirectorMiddleware(this IApplicationBuilder app, ILoggerFactory? loggerFactory = null)
        {
            if(loggerFactory != null)
            {
                app.UseDataAccessMiddleware(loggerFactory);
                app.UseTDAuthenticationMiddleware(loggerFactory);
            }
            else
            {
                app.UseDataAccessMiddleware();
                app.UseTDAuthenticationMiddleware();
            }
            return app;
        }
    }
}
