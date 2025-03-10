﻿using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Middleware.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            //Custom operasyon
            Console.WriteLine("selam custom");
            await _next.Invoke(httpContext);
            Console.WriteLine("AAaselam custom");
        }
    }
}
