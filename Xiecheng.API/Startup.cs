using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Xiecheng.API.Services;
using Xiecheng.API.Database;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Xiecheng.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }//Ҫ��Appsetting�е����� Ҫ�����

        public Startup(IConfiguration configuration) //����ע��configuration
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        //services.AddTransient: ÿһ�������ʱ�򴴽�һ���µ����ݲֿ� �����Ժ�ע�� 
        //services.AddSingleton��ֻ��һ���ֿ� 
        //services.AddScoped����������֮��
        public void ConfigureServices(IServiceCollection services)//����ע�����
        {
            services.AddControllers();//MVC Controller��������
            services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();
            
            //ע��DbContext ͬʱ�������������ݿ�
            services.AddDbContext<AppDbContext>(option => {
                option.UseSqlServer(Configuration["DbContext:ConnectionString"]);
            });

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
                endpoints.MapControllers();//MVC�м������request pipeline������http����·��
            });
        }
    }
}
