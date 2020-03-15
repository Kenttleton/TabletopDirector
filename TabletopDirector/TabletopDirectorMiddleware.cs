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

        public TabletopDirectorMiddleware(RequestDelegate next, ILoggerFactory? logFactory = null)
        {
            _next = next;
            if(logFactory != null)
            {
                _logger = logFactory.CreateLogger("Tabletop Director Middleware");
            }
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            _logger.LogInformation("Tabletop Director Initializing...");

            await _next(httpContext);
        }
    }
}
