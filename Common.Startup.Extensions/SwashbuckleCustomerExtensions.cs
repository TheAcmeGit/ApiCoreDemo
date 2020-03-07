using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace Common.Startup.Extensions
{
    public static class SwashbuckleCustomerExtensions
    {
        public static IServiceCollection AddCustomerSwashbuckle(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Email = "admin@qq.com",
                        Name = "admin",
                        Url = new Uri("https://www.admin.com")//网站连接
                    },
                    Description = "描述",
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
                string str = System.AppDomain.CurrentDomain.BaseDirectory;

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlFile = $"{System.AppDomain.CurrentDomain.BaseDirectory+ System.AppDomain.CurrentDomain.FriendlyName}.xml";//添加接口描述文档
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath,true);//第一个参数为：接口文档地址，第二个参数为：是否展示控制器描述注释
            });
            return services;
        }


        public static IApplicationBuilder UseCustomerSwashbuckle(this IApplicationBuilder app)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}
