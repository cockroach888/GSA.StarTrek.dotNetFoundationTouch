using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace GenericHost4Lib01
{
    /// <summary>
    /// 
    /// </summary>
    public static class WinFormBuilderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TStartForm"></typeparam>
        /// <param name="hostBuilder"></param>
        /// <returns></returns>
        public static IHostBuilder UseWinForm<TStartForm>(this IHostBuilder hostBuilder)
            where TStartForm : Form
        {
            return UseWinForm<TStartForm>(hostBuilder, _ => new WinFormOptions());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TStartForm"></typeparam>
        /// <param name="hostBuilder"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static IHostBuilder UseWinForm<TStartForm>(this IHostBuilder hostBuilder, Action<WinFormOptions> configure)
            where TStartForm : Form
        {
            return hostBuilder.ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<TStartForm>();
                services.AddHostedService<WinFormHostedService<TStartForm>>();
                services.Configure(configure);
            });
        }
    }
}
