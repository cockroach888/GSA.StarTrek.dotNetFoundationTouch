using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace GenericHost4Lib01
{
    /// <summary>
    /// 通用主机使用示例
    /// </summary>
    public class GenericHostSample : IDisposable
    {
        private IHost _host;

        public async Task<IHost> Run(string[] args)
        {
            _host = CreateHostBuilder(args).Build();
            await _host.RunAsync();
            return _host;
        }

        private IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                       .ConfigureServices((hostContext, services) =>
                       {
                           services.AddHostedService<HostedServiceSample>();

                           // 接口引用 IUltraman 顶层接口，创建独立接口与实现对应。
                           services.AddSingleton<Sample2Interface.IUltramanAgul, Sample2Indirect.UltramanAgul>();
                           services.AddSingleton<Sample2Interface.IUltramanDyna, Sample2Indirect.UltramanDyna>();
                           services.AddSingleton<Sample2Interface.IUltramanGaia, Sample2Indirect.UltramanGaia>();
                           services.AddSingleton<Sample2Interface.IUltramanMax, Sample2Indirect.UltramanMax>();
                           services.AddSingleton<Sample2Interface.IUltramanMebius, Sample2Indirect.UltramanMebius>();
                           services.AddSingleton<Sample2Interface.IUltramanTiga, Sample2Indirect.UltramanTiga>();

                           // 直接实现顶层接口 IUltraman
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanAgul>();
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanDyna>();
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanGaia>();
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanMax>();
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanMebius>();
                           services.AddSingleton<Sample2Interface.IUltraman, Sample2Direct.UltramanTiga>();


                           // 统一接口实现，增加临时性获取服务。
                           services.AddSingleton<Sample2Direct.UltramanAgul>();
                           services.AddSingleton<Sample2Direct.UltramanDyna>();
                           services.AddSingleton<Sample2Direct.UltramanGaia>();
                           services.AddSingleton<Sample2Direct.UltramanMax>();
                           services.AddSingleton<Sample2Direct.UltramanMebius>();
                           services.AddSingleton<Sample2Direct.UltramanTiga>();

                           services.AddTransient<Func<string, Sample2Interface.IUltraman>>(serviceProvider => key =>
                           {
                               switch (key)
                               {
                                   case "Agul":
                                       return serviceProvider.GetService<Sample2Direct.UltramanAgul>();
                                   case "Dyna":
                                       return serviceProvider.GetService<Sample2Direct.UltramanDyna>();
                                   case "Gaia":
                                       return serviceProvider.GetService<Sample2Direct.UltramanGaia>();
                                   case "Max":
                                       return serviceProvider.GetService<Sample2Direct.UltramanMax>();
                                   case "Mebius":
                                       return serviceProvider.GetService<Sample2Direct.UltramanMebius>();
                                   case "Tiga":
                                       return serviceProvider.GetService<Sample2Direct.UltramanTiga>();
                                   default:
                                       return default(Sample2Interface.IUltraman);
                               }
                           });
                       })
                       .ConfigureAppConfiguration((hostContext, configBuilder) =>
                       {
                           // do something.
                       })
                       .ConfigureHostConfiguration(configHost =>
                       {
                           // do something.
                       })
                       .ConfigureLogging((hostContext, logBuilder) =>
                       {
                           // do something.
                       })
                       .ConfigureWebHostDefaults(webBuilder =>
                       {
                           webBuilder.UseUrls("http://*:5000;http://localhost:5001;https://hostname:5002")
                                     .UseStartup<Startup>();
                       })
                       .UseWinForm<FormViews.MainForm>();
        }

        /// <summary>
        /// 资源释放
        /// </summary>
        public async void Dispose()
        {
            using (_host)
            {
                await _host.StopAsync(TimeSpan.FromSeconds(5));
            }
        }
    }
}
