using Microsoft.AspNetCore.Builder;
using Nightrain.Base.Core.Middlewares;

namespace Nightrain.Base.Core.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomException(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
