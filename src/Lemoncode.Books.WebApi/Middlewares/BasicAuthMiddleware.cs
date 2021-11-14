using Lemoncode.Books.Application.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Lemoncode.Books.WebApi.Middlewares
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public BasicAuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext httpContext)
        {            
            Boolean.TryParse(_configuration.GetValue<string>("BasicAuthentication:IsEnabled"), out bool isAuthenticationEnabled);

            if (isAuthenticationEnabled)
            {
                var authHeader = httpContext.Request.Headers["Authorization"].ToString();
                if (string.IsNullOrWhiteSpace(authHeader))
                {
                    httpContext.Response.StatusCode = 401;
                    return;
                }

                var isValidBasicAuth = AuthorizationUtil.TryGetCredentials(authHeader, out var username, out var password);
                if (!isValidBasicAuth)
                {
                    httpContext.Response.StatusCode = 401;
                    return;
                }

                var isValidCredentials = username == _configuration.GetValue<string>("BasicAuthentication:Username") &&
                    password == _configuration.GetValue<string>("BasicAuthentication:Password");
                if (!isValidCredentials)
                {
                    httpContext.Response.StatusCode = 401;
                    return;
                }
            }

            // otherwise all is good to continue processing the http request
            await _next(httpContext);
        }
    }
}
