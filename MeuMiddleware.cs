using Microsoft.AspNetCore.Routing.Template;
using Serilog;
using System.Diagnostics;

namespace PorBaixoDosPanos
{
    public class MeuMiddleware
    {
        

        public class TemplateMidlleware
        {
            private readonly RequestDelegate _next;

            public TemplateMidlleware(RequestDelegate next)
            {

                _next = next;

            }
            public async Task InvokeAsync(HttpContext httpcontext)
            {
                await _next(httpcontext);
            }
        }
        public class LogTemplateMidlleware
        {
            private readonly RequestDelegate _next;

            public LogTemplateMidlleware(RequestDelegate next)
            {

                _next = next;

            }
            public async Task InvokeAsync(HttpContext httpcontext)
            {
                //Faz algo antes 
                var sw = Stopwatch.StartNew();

                await _next(httpcontext);

                sw.Stop();

                Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateBootstrapLogger();
                Log.Information($"A execução demorou {sw.Elapsed.TotalMilliseconds}ms ({sw.Elapsed.TotalMilliseconds}) segundos");
            }
        }
      

    }
}
