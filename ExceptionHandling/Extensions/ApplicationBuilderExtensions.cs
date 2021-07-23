using ExceptionHandling.Middleware;
using Microsoft.AspNetCore.Builder;

namespace ExceptionHandling.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void AddExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
