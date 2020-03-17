using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TabletopDirector.DataAccess.Contexts;

namespace TabletopDirector.DataAccess
{
    public static class ServicesConfiguration
    {
        public static void AddDataAccess(this IServiceCollection services, ILoggerFactory? loggerFactory = null)
        {
            if(loggerFactory != null)
            {
                services.AddDbContextPool<ApplicationContext>(options => options.UseLoggerFactory(loggerFactory).UseNpgsql(""));
            }
            else
            {
                services.AddDbContextPool<ApplicationContext>(options => options.UseNpgsql(""));
            }
        }
    }
}
