using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TabletopDirector.GameMaster
{
    public class GameMasterMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public GameMasterMiddleware(RequestDelegate next, ILoggerFactory? logFactory = null)
        {
            _next = next;
            if(logFactory != null)
            {
                _logger = logFactory.CreateLogger("Game Master Middleware");
            }
        }

        public async Task Invoke(HttpContext httpContext) 
        {
            _logger.LogInformation("Game Master Initializing...");

            await _next(httpContext);
        }
    }
}
