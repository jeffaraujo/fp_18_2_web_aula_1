using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap01.Middlewares
{
    public static class MiddlewareExtensions
    {

        //Usando Extensions...
        public static IApplicationBuilder UseMeuLogPreza(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
