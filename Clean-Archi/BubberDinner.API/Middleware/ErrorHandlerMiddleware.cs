using BubberDinner.Application.Models.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

namespace BubberDinner.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (MainExecption ex)
            {
                await HandelException(httpContext, ex);
            }

        }

        public static Task HandelException(HttpContext httpContext, MainExecption ex)
        {
            var problemDetails = new ProblemDetails{
                Type = ex.Title,
                Title = ex.Message,
                Status = ex.Status,
            };
            var result = JsonSerializer.Serialize(problemDetails);
            return httpContext.Response.WriteAsync(result);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ErrorHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
