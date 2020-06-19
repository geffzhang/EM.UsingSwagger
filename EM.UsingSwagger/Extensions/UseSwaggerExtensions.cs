﻿using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace EM.UsingSwagger.Extensions
{
    public static class UseSwaggerExtensions
    {
        /// <summary>
        /// Использовать Basic authorize для Swagger API
        /// </summary>
        /// <param name="app"></param>
        /// <param name="versionName"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSwaggerByBasicAuth(this IApplicationBuilder app, string versionName = "basicauth")
        {
            SwaggerBuilderExtensions.UseSwagger(app);
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{versionName}/swagger.json", $".NET Core API with Basic Auth");
                c.RoutePrefix = "swagger/ui";
            });

            return app;
        }

        /// <summary>
        /// Использовать JWT authorize для Swagger API
        /// </summary>
        /// <param name="app"></param>
        /// <param name="versionName"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSwaggerByJWTToken(this IApplicationBuilder app, string versionName = "jwt")
        {
            SwaggerBuilderExtensions.UseSwagger(app);
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{versionName}/swagger.json", $".NET Core API with JWT Token");
                c.RoutePrefix = "swagger/ui";
            });

            return app;
        }
    }
}
