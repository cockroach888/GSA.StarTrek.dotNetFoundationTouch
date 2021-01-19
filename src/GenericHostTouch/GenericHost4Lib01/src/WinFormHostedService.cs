using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericHost4Lib01
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TStartForm"></typeparam>
    public class WinFormHostedService<TStartForm> : IHostedService, IDisposable
        where TStartForm : Form
    {
        private CancellationTokenRegistration _applicationStoppingRegistration;

        private readonly WinFormOptions _options;
        private readonly IHostApplicationLifetime _appLifetime;
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <param name="appLifetime"></param>
        /// <param name="serviceProvider"></param>
        public WinFormHostedService(
            IOptions<WinFormOptions> options,
            IHostApplicationLifetime appLifetime,
            IServiceProvider serviceProvider)
        {
            _options = options.Value;
            _appLifetime = appLifetime;
            _serviceProvider = serviceProvider;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _applicationStoppingRegistration = _appLifetime.ApplicationStopping.Register(state =>
            {
                ((WinFormHostedService<TStartForm>)state).OnApplicationStopping();
            }, this);

            var thread = new Thread(StartUiThread)
            {
                IsBackground = true
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            return Task.CompletedTask;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;


        /// <summary>
        /// 启动应用程序 UI 线程
        /// </summary>
        private void StartUiThread()
        {
            Application.SetHighDpiMode(_options.HighDpiMode);

            if (_options.EnableVisualStyles)
            {
                Application.EnableVisualStyles();
            }

            Application.SetCompatibleTextRenderingDefault(_options.CompatibleTextRenderingDefault);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            var form = _serviceProvider.GetService<TStartForm>();
            Application.Run(form);
        }
        /// <summary>
        /// 应用程序退出发生时
        /// </summary>
        private void OnApplicationStopping()
        {
            var form = _serviceProvider.GetService<TStartForm>();
            if (form.IsHandleCreated)
            {
                form.Invoke(new Action(() =>
                {
                    form.Close();
                    form.Dispose();
                }));
            }
        }
        /// <summary>
        /// 应用程序退出时
        /// </summary>
        /// <param name="sender">传递对象</param>
        /// <param name="e">传递事件</param>
        private void OnApplicationExit(object sender, EventArgs e) => _appLifetime.StopApplication();


        /// <summary>
        /// 资源释放
        /// </summary>
        public void Dispose()
        {
            Application.ApplicationExit -= OnApplicationExit;
            using (_applicationStoppingRegistration) { }
        }
    }
}
