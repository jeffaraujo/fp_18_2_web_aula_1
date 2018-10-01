using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Middlewares
{
    public class LogMiddleware
    {

        //Classe Middleware




        private RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //TODO: programar isso
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            await _next(context); //Chamando o próximo Middleware...
            stopwatch.Stop();
            Console.WriteLine($"Demorou {stopwatch.ElapsedMilliseconds} ms");

        }

    }
}
