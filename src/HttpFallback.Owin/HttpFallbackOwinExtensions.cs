using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using System.Net;
using HttpFallback.Owin;

namespace Owin
{
    public static class HttpFallbackOwinExtensions
    {
        public static IAppBuilder UseHttpFallback(this IAppBuilder app, int code)
        {
            app.Use<HttpFallbackOwinMiddleware>(code);
            return app;
        }
        public static IAppBuilder UseHttpFallback(this IAppBuilder app, HttpStatusCode statusCode)
        {
            app.UseHttpFallback((int)statusCode);
            return app;
        }
    }
}
