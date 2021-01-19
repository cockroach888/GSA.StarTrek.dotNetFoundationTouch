using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView4App01
{
    public partial class MainForm : Form
    {
        private WebView2 _webView;

        public MainForm()
        {
            InitializeComponent();
            Resize += new EventHandler(MainForm_Resize);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_webView != null)
            {
                _webView.Size = ClientSize - new Size(_webView.Location);
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // 
            // 创建一个新的 WebView2 WinForms 控件，默认 CoreWebView2 属性为空。
            // 调用 EnsureCoreWebView2Async(CoreWebView2Environment) 初始化底层。
            // 
            _webView = new WebView2();


            _webView.CreationProperties = null;
            _webView.ZoomFactor = 1D;
            _webView.Dock = DockStyle.Fill;


            // WebView2 对象初始化并处于可用状态时
            _webView.CoreWebView2Ready += (s, e) =>
            {
                // do something.
            };


            // 下载 Fixed Version 版本，放解压到指定目录。
            // https://developer.microsoft.com/en-us/microsoft-edge/webview2/

            // WebView2 环境变量相关配置
            var env = await CoreWebView2Environment.CreateAsync(browserExecutableFolder: @"D:\\DocumentCenter\WebView2\Edge\", userDataFolder: @"D:\\DocumentCenter\WebView2\UserData\");
            // WebView2 初始化
            await _webView.EnsureCoreWebView2Async(env);

            // WebView2 加载起始页面
            _webView.Source = new Uri(@"https://www.microsoft.com");


            // 禁止 web 内容访问主机对象
            _webView.CoreWebView2.Settings.AreHostObjectsAllowed = false;
            // 禁止 web 内容将 web 消息发布到本机应用程序
            _webView.CoreWebView2.Settings.IsWebMessageEnabled = false;
            // 禁止 web 内容运行脚本（如：当显示静态 html 内容时）
            _webView.CoreWebView2.Settings.IsScriptEnabled = false;
            // 禁止显示 web 内容或对话框
            _webView.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = false;


            palMain.Controls.Add(_webView);
        }


        private void WebView2ToDoSomething()
        {
            // 
            // 创建一个新的 WebView2 WinForms 控件，默认 CoreWebView2 属性为空。
            // 调用 EnsureCoreWebView2Async(CoreWebView2Environment) 初始化底层。
            // 
            //var currentView = new WebView2();



            // 底层的 CoreWebView2 对象。
            // 使用此属性可以对 WebView2 内容执行比 WebView2 上暴露的更多操作。
            // 在初始化之前，此值为空。您可以通过 InitializeAsync 方法强制底层 CoreWebView2 初始化。
            //currentView.CoreWebView2 { get; }



            // 显式触发控件的 CoreWebView2 的初始化。

            // 环境的初始化。

            // 一个预先创建的 CoreWebView2Environment，应该用来创建 CoreWebView2。
            // 创建您自己的环境可以让您控制几个选项，这些选项会影响 CoreWebView2 的初始化方式。
            // 如果你传递null（默认值），那么将自动创建并使用一个默认环境。

            // 一个代表后台初始化过程的任务。当任务完成后，那么 CoreWebView2属性将可供使用（即非空）。
            // 请注意，控件的 CoreWebView2Ready 事件将在任务完成之前被调用。

            // T: System.InvalidOperationException。当从非UI线程调用时抛出。

            // 调用此方法的额外次数将不会产生任何影响（任何指定的环境都会被忽略），并返回与第一次调用相同的CoreWebView2Ready事件。
            // 在通过设置 Source 属性隐式触发初始化后调用此方法将不会有任何影响（任何指定的环境都会被忽略），而只是返回一个代表该初始化已经进行的Task。
            //currentView.EnsureCoreWebView2Async(CoreWebView2Environment environment = null);



            // CoreWebView2 对象初始化完成时，并且有效时（即非空）被触发。
            //currentView.CoreWebView2Ready += (s, e) =>
            //{
            //    // do something.
            //};



            // 是否能够导航到导航历史中的前一页，true 可以 / false 不可以。
            // 如果CanGoBack改变了值，则会引发 CoreWebView2.HistoryChanged事件。
            //currentView.CanGoBack { get; }
            //currentView.CoreWebView2.CanGoBack { get; }



            // 是否能够导航到导航历史中的下一页，true 可以 / false 不可以。
            // 如果CanGoForward改变了值，则会引发 CoreWebView2.HistoryChanged 事件。
            //currentView.CanGoForward { get; }
            //currentView.CoreWebView2.CanGoForward { get; }



            // Source 属性是 WebView2 的顶层文档的 URI
            // 设置 Source 相当于调用 CoreWebView2.Navigate(System.String)
            // 设置 Source 将触发 CoreWebView2 的初始化，如果尚未初始化的话。
            // Source 的默认值为 null，表示 CoreWebView2 尚未初始化。
            // T: System.ArgumentException：指定的值不是一个绝对的System.Uri。
            // T: System.NotImplementedException：指定的值为空，控件已初始化。
            //currentView.Source { get; set; }

            // 获取当前顶层文档的URI。
            // 该值作为 CoreWebView2.SourceChanged 事件的一部分，在某些情况下可能会发生变化，例如导航到不同的站点或片段导航。
            // 对于其他类型的导航，如页面刷新或具有与当前页面相同URL的history.pushState，它保持不变。
            //currentView.CoreWebView2.Source { get; }



            // WebView2 的缩放系数。
            //currentView.ZoomFactor { get; set; }



            // 创建 WebView2 时使用的基本属性，包含设置 Edge 浏览器位置，用户数据目录位置，浏览器语言。
            // 如果想配置更多的初始化环境变量，请使用 CoreWebView2Environment 并传递至 EnsureCoreWebView2Async 方法。
            // T:System.InvalidOperationException: 如果控件的CoreWebView2的初始化已经开始，则抛出该异常。
            //currentView.CreationProperties { get; set; }



            // 
            // WebView2 导航事件以及顺序
            // 

            // 当WebView主框架请求允许导航到不同的URI时，NavigationStarting会被引发。
            // 重定向也会引发这个事件。您可以阻止相应的导航，直到事件处理程序返回。
            //currentView.NavigationStarting += (s, e) =>
            //{
            //    // do something.
            //};
            //currentView.CoreWebView2.NavigationStarting += (s, e) =>
            //{
            //    // do something.
            //};

            // 当导航到不同的站点或片段导航时，SourceChanged会被引发。
            // 对于其他类型的导航，如页面刷新或与当前页面具有相同 URL 的 history.pushState，它不会被引发。
            // 该事件在 CoreWebView2.ContentLoading 之前被引发，用于导航到一个新文档。
            //currentView.SourceChanged += (s, e) =>
            //{
            //    // do something.
            //};
            //currentView.CoreWebView2.SourceChanged += (s, e) =>
            //{
            //    // do something.
            //};

            // ContentLoading在任何内容被加载之前就会被引发，包括使用 CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(System.String) 添加的脚本。
            // 如果发生同一页面导航（如通过片段导航或history.pushState导航），则不会引发ContentLoading。
            // 该操作跟随 CoreWebView2.NavigationStarting 和 CoreWebView2.SourceChanged事件，
            // 并在 CoreWebView2.HistoryChanged 和 CoreWebView2.NavigationCompleted 事件之前进行。
            //currentView.ContentLoading += (s, e) =>
            //{
            //    // do something.
            //};
            //currentView.CoreWebView2.ContentLoading += (s, e) =>
            //{
            //    // do something.
            //};

            // 当顶层文档的导航历史发生变化时，HistoryChanged 被引发。
            // 使用 HistoryChanged 来验证 CoreWebView2.CanGoBack 或 CoreWebView2.CanGoForward 的值是否已经改变。
            // 当使用 CoreWebView2.GoBack 或 CoreWebView2.GoForward 时也会引发HistoryChanged。
            // HistoryChanged 在 CoreWebView2.SourceChanged 和 CoreWebView2.ContentLoading 之后被引发。
            //currentView.CoreWebView2.HistoryChanged += (s, e) =>
            //{
            //    // do something.
            //};

            // 在顶层文档的导航成功或不成功完成渲染后，NavigationCompleted 会被触发。
            // 当WebView已经完全加载完毕（body.onload已经被触发）或加载停止并出现错误时，NavigationCompleted事件会被触发。
            //currentView.NavigationCompleted += (s, e) =>
            //{
            //    // do something.
            //};
            //currentView.CoreWebView2.NavigationCompleted += (s, e) =>
            //{
            //    // do something.
            //};



            // WebMessageReceived在Web内容通过chrome.webview.postMessage向应用主机发送消息后发出。
            // 当 CoreWebView2Settings.IsWebMessageEnabled 设置被设置且WebView的顶层文档运行window.chrome.webview.postMessage时，
            // WebMessageReceived就会被引发。 postMessage函数为void postMessage(object)，其中object为JSON转换支持的任何对象。
            // 当postMessage被调用时，处理程序的Invoke方法将被调用，对象参数postMessage被转换为JSON字符串。
            //currentView.WebMessageReceived += (s, e) =>
            //{
            //    // do something.
            //};
            //currentView.CoreWebView2.WebMessageReceived += (s, e) =>
            //{
            //    // do something.
            //};



            // 当 ZoomFactor 属性发生变化时，ZoomFactorChanged会派发。
            // 这相当于 CoreWebView2Controller.ZoomFactorChanged 事件。
            //currentView.ZoomFactorChanged += (s, e) =>
            //{
            //    // do something.
            //};
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (_webView != null && _webView.CoreWebView2 != null)
            {
                _webView.CoreWebView2.Navigate(txtAddress.Text.Trim());
            }
        }
    }
}
