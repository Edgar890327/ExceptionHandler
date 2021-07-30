using System;
using System.Threading.Tasks;
using ExceptionHandling.CustomException;
using Microsoft.AspNetCore.Http;

namespace ExceptionHandling.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private const string CONTENT_TYPE = "text";
        private const string DEFAULT_ERROR_MESSAGE = "An error occurred.";
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                if (e.InnerException is BaseException)
                    await HandleException(e.InnerException, context);

                await HandleException(e, context);
            }
        }

        private async Task HandleException(Exception exception, HttpContext context)
        {
            context.Response.ContentType = CONTENT_TYPE;
            var displayMessage = DEFAULT_ERROR_MESSAGE;
            context.Response.StatusCode = 500;
            if (exception is BaseException baseException)
            {
                context.Response.StatusCode = baseException.StatusCode;
                displayMessage = baseException.Message;
            }

            await context.Response.WriteAsync(displayMessage);
        }

    }
}