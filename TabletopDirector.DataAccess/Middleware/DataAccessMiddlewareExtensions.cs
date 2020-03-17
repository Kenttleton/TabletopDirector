using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.DataAccess.Middleware
{
    public static class DataAccessMiddlewareExtensions
    {
        public static IApplicationBuilder UseDataAccessMiddleware(this IApplicationBuilder app, ILoggerFactory? loggerFactory = null)
        {
            if(loggerFactory != null)
            {
                app.UseMiddleware<DataAccessMiddleware>(loggerFactory);
            }
            else
            {
                app.UseMiddleware<DataAccessMiddleware>();
            }
            return app;
        }
    }
}
