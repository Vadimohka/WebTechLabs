using WebApplication1.Middleware;
using Microsoft.AspNetCore.Builder;

namespace WebApplication1.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
