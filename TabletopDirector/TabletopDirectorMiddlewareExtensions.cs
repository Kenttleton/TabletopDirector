using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector
{
    public static class TabletopDirectorMiddlewareExtensions
    {
        public static IApplicationBuilder UseTabletopDirectorMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TabletopDirectorMiddleware>();
        }
    }
}
