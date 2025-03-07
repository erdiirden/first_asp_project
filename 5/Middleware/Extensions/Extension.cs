using Microsoft.AspNetCore.Builder;
using Middleware.Middlewares;

namespace Middleware.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        { 
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
