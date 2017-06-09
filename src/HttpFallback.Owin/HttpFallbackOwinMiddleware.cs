using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HttpFallback.Owin
{
    public class HttpFallbackOwinMiddleware : OwinMiddleware
    {
        public HttpFallbackOwinMiddleware(OwinMiddleware next, int status) : base(next)
        {
            this.status = status;
        }

        public override async Task Invoke(IOwinContext context)
        {
            var pages = GetPages();
            if (pages.ContainsKey(status))
            {
                var pageName = pages[status];
                using (var pageStream = this.GetType().Assembly.GetManifestResourceStream(pageName))
                {
                    await pageStream.CopyToAsync(context.Response.Body);
                }
            }
            else
            {
                var pageName = pages[0];
                using (var pageStream = this.GetType().Assembly.GetManifestResourceStream(pageName))
                using (var ms = new MemoryStream())
                {
                    await pageStream.CopyToAsync(ms);
                    var bytes = ms.ToArray();
                    var tx = Encoding.UTF8.GetString(bytes);
                    tx = tx.Replace("{{code}}", status.ToString())
                        .Replace("{{title}}", "Unknown")
                        .Replace("{{message}}", "An unknown error has occurred");
                    bytes = Encoding.UTF8.GetBytes(tx);
                    context.Response.Write(bytes, 0, bytes.Length);
                }
            }
            context.Response.StatusCode = status;
            await context.Response.Body.FlushAsync();
        }


        private Dictionary<int, string> GetPages()
        {
            if (_pages != null)
                return _pages;
            var asm = this.GetType().Assembly;
            var asmname = asm.GetName().Name;
            var ns = asmname + ".Pages";
            var names = asm.GetManifestResourceNames();
            var regex = new Regex(ns.Replace(".", "\\.") + @"\.HTTP(\d+).html");
            var pages = names.Where(name => regex.IsMatch(name))
                .Select(name => new
                {
                    Code = Convert.ToInt32(regex.Match(name).Groups[1].Value),
                    Name = name,

                })
                .ToDictionary(x => x.Code, x => x.Name);
            _pages = pages;
            return _pages;
        }

        private static Dictionary<int, string> _pages = null;
        private readonly int status;
    }
}
