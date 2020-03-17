using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TabletopDirector
{
    public class TabletopDirectorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public TabletopDirectorMiddleware(RequestDelegate next, ILoggerFactory? loggerFactory = null)
        {
            _next = next;
            if(loggerFactory != null)
            {
                _logger = loggerFactory.CreateLogger("Tabletop Director Middleware");
            }
        }

        public async Task InvokeAsync(HttpContext httpContext) 
        {
            _logger.LogInformation("Tabletop Director Initializing...");

            // Get Context
            // Check/Set Auth

            await _next(httpContext);
        }
    }
}
