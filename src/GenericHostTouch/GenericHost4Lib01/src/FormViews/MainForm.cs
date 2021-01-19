using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericHost4Lib01.Sample2Interface;
using Microsoft.Extensions.DependencyInjection;

namespace GenericHost4Lib01.FormViews
{
    public partial class MainForm : Form
    {
        private IServiceProvider _services;

        public MainForm(IServiceProvider services)
        {
            _services = services;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //using IServiceScope serviceScope = _services.CreateScope();
            //var provider = serviceScope.ServiceProvider;

            //_ = provider.GetRequiredService<IUltraman>();

            //_ = provider.GetRequiredService<IUltramanAgul>();
            //_ = provider.GetRequiredService<IUltramanDyna>();
            //_ = provider.GetRequiredService<IUltramanGaia>();
            //_ = provider.GetRequiredService<IUltramanMax>();
            //_ = provider.GetRequiredService<IUltramanMebius>();
            //_ = provider.GetRequiredService<IUltramanTiga>();

            cboxImplementation.SelectedIndex = 0;
        }


        private void ShowMessage(string msg)
        {
            lstDisplay.Items.Insert(0, $"{DateTime.Now:yyyy-MM-dd HH:mm} {msg}");
        }

        private void ShowServices<TImplementation>() where TImplementation : IUltraman
        {
            var items = _services.GetServices<TImplementation>();

            ShowMessage($"Get {nameof(TImplementation)}: {items.Count()} items.");

            foreach (var item in items)
            {
                ShowMessage($"{item}, Name: {item.Name}, Text: {item.Text}.");
            }

            ShowMessage(string.Empty);
        }


        private void btnGetDirect_Click(object sender, EventArgs e)
        {
            ShowServices<IUltraman>();
        }

        private void btnGetOnly_Click(object sender, EventArgs e)
        {
            var item = _services.GetService<IUltraman>($"{cboxImplementation.SelectedItem}");
            ShowMessage($"{item}, Name: {item.Name}, Text: {item.Text}.");
        }


        private void btnGetAgul_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanAgul>();
        }

        private void btnGetDyna_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanDyna>();
        }

        private void btnGetGaia_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanGaia>();
        }

        private void btnGetMax_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanMax>();
        }

        private void btnGetMebius_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanMebius>();
        }

        private void btnGetTiga_Click(object sender, EventArgs e)
        {
            ShowServices<IUltramanTiga>();
        }
    }
}
