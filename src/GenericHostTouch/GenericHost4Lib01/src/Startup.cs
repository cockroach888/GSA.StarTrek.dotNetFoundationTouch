using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericHost4Lib01
{
    /// <summary>
    /// ASP.NET Core 启动类
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// ASP.NET Core 启动类
        /// </summary>
        /// <param name="configuration">应用程序配置（键/值对）对象</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 应用程序配置（键/值对）
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// DI 容器服务注入事件
        /// </summary>
        /// <param name="services">DI 容器服务</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }
        /// <summary>
        /// 应用程序配置管道与 Web 主机运行环境设定
        /// </summary>
        /// <param name="app">应用程序配置管道</param>
        /// <param name="env">Web 主机运行环境信息</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // 强制所有访问重定向为 Https 安全请求
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            app.UseWelcomePage();
        }
    }
}
