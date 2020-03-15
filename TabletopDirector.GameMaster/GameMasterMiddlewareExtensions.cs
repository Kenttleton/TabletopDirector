using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.GameMaster
{
    public static class GameMasterMiddlewareExtensions
    {
        public static IApplicationBuilder UseGameMasterMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GameMasterMiddleware>();
        }
    }
}
