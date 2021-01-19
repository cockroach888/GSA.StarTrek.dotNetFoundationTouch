using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace GenericHost4Lib01
{
    /// <summary>
    /// Hosted Service 接口应用示例类
    /// </summary>
    public class HostedServiceSample : IHostedService
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Hosted Service 接口应用示例类
        /// </summary>
        /// <param name="logger">日志服务对象</param>
        /// <param name="appLifetime">Host 应用程序生命周期对象</param>
        public HostedServiceSample(ILogger<HostedServiceSample> logger, IHostApplicationLifetime appLifetime)
        {
            _logger = logger;

            appLifetime.ApplicationStarted.Register(OnStarted);
            appLifetime.ApplicationStopping.Register(OnStopping);
            appLifetime.ApplicationStopped.Register(OnStopped);
        }


        /// <summary>
        /// StartAsync 事件回调函数
        /// </summary>
        /// <param name="cancellationToken">取消令牌对象</param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("1.作为触发 StartAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }
        /// <summary>
        /// StopAsync 事件回调函数
        /// </summary>
        /// <param name="cancellationToken">取消令牌对象</param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("4.作为触发 StopAsync 事件时的回调函数。");

            return Task.CompletedTask;
        }


        /// <summary>
        /// OnStarted 事件回调函数
        /// </summary>
        private void OnStarted()
        {
            _logger.LogInformation("2.作为触发 OnStarted 事件时的回调函数。");
        }
        /// <summary>
        /// OnStopping 事件回调函数
        /// </summary>
        private void OnStopping()
        {
            _logger.LogInformation("3.作为触发 OnStopping 事件时的回调函数。");
        }
        /// <summary>
        /// OnStopped 事件回调函数
        /// </summary>
        private void OnStopped()
        {
            _logger.LogInformation("5.作为触发 OnStopped 事件时的回调函数。");
        }
    }
}
