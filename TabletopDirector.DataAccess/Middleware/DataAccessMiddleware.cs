using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TabletopDirector.DataAccess.Middleware
{
    public class DataAccessMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger = null;

        public DataAccessMiddleware(RequestDelegate next, ILoggerFactory? logFactory = null)
        {
            _next = next;
            if(logFactory != null)
            {
                _logger = logFactory.CreateLogger("Data Access Middleware");
            }
        }

        public async Task InvokeAsync(HttpContext httpContext) 
        {
            if(_logger != null)
            {
                _logger.LogInformation("Data Access Initializing...");
            }
            
            // Get the context and pass it on

            await _next(httpContext);
        }
    }
}
