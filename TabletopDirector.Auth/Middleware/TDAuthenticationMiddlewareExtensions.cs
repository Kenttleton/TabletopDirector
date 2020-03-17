using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.Auth.Middleware
{
    public static class TDAuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseTDAuthenticationMiddleware(this IApplicationBuilder app, ILoggerFactory? loggerFactory = null)
        {
            if(loggerFactory != null)
            {
                app.UseMiddleware<TDAuthenticationMiddleware>(loggerFactory);
            }
            else
            {
                app.UseMiddleware<TDAuthenticationMiddleware>();
            }
            return app;
        }
    }
}
