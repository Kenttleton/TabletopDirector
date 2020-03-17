using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TabletopDirector.Auth.Middleware
{
    public class TDAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger = null;

        public TDAuthenticationMiddleware(RequestDelegate next, ILoggerFactory? logFactory = null)
        {
            _next = next;
            if(logFactory != null)
            {
                _logger = logFactory.CreateLogger("Authentication Middleware");
            }
        }

        public async Task InvokeAsync(HttpContext httpContext) 
        {
            if(_logger != null)
            {
                _logger.LogInformation("Authentication Initializing...");
            }
            
            // Check httpContext and pass to Rules or keep it moving

            await _next(httpContext);
        }
    }
}
