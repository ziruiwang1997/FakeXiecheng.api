using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xiecheng.API.Services;

namespace Xiecheng.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //services.AddTransient: 每一次请求的时候创建一个新的数据仓库 结束以后注销 
        //services.AddSingleton：只有一个仓库 
        //services.AddScoped：介于两者之间
        public void ConfigureServices(IServiceCollection services)//这里注入服务
        {
            services.AddControllers();//MVC Controller功能启用
            services.AddTransient<ITouristRouteRepository, MockTouristRouteRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//MVC中间件加入request pipeline来处理http请求路由
            });
        }
    }
}
