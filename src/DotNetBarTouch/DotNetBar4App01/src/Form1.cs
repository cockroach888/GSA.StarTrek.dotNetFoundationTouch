using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetBar4App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ToastNotification.ToastFont = new System.Drawing.Font("宋体", 12);
            ToastNotification.ToastMargin = new DevComponents.DotNetBar.Padding(3, 3, 3, 24);
        }



        private void buttonX1_Click(object sender, EventArgs e)
        {
            ToastNotification.Show(this,
                 "This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。",
                 Properties.Resources.warning,
                 4000,
                 eToastGlowColor.Red,
                 eToastPosition.BottomCenter);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ToastNotification.Show(this,
                "This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。",
                Properties.Resources.information,
                2000,
                eToastGlowColor.Green,
                eToastPosition.MiddleCenter);
        }





        private void btnUsualDialogLong4DotNetBar_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox4DotNetBar.Show("This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。★★★"
                        , numSecond: 60, icon: Properties.Resources.warning);
            textBoxX1.Text = $"{result}";
        }

        private void btnUsualDialogShort4DotNetBar_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox4DotNetBar.Show("非常抱歉，应用程序发生了未知的异常，如果继续程序，程序可能处于不确定的状态。This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.", numSecond: 60, icon: Properties.Resources.information);
            textBoxX1.Text = $"{result}";
        }

        private void btnConfirmDialog4DotNetBar_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox4DotNetBar.ShowConfirm("This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。★★★"
                                           , icon: Properties.Resources.clear);
            textBoxX1.Text = $"{result}";
        }

        private void btnErrorDialog4DotNetBar_Click(object sender, EventArgs e)
        {
            Exception exception = null;
            try
            {
                using (var fs = File.OpenRead(@"D:\\text.txt"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            textBoxX1.Clear();
            var result = MsgBox4DotNetBar.ShowError(exception);
            textBoxX1.Text = $"{result}";
        }





        private void btnUsualDialogLong_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox.Show("This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。★★★"
                        , numSecond: 60, icon: Properties.Resources.warning);
            textBoxX1.Text = $"{result}";
        }

        private void btnUsualDialogShort_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox.Show("非常抱歉，应用程序发生了未知的异常，如果继续程序，程序可能处于不确定的状态。This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.This is a message.", numSecond: 60, icon: Properties.Resources.information);
            textBoxX1.Text = $"{result}";
        }

        private void btnConfirmDialog_Click(object sender, EventArgs e)
        {
            textBoxX1.Clear();
            var result = MsgBox.ShowConfirm("This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。█◆◆█This is a message. 1这是一条消息。This is a message. 2这是一条消息。This is a message. 3这是一条消息。This is a message. 4这是一条消息。This is a message. 5这是一条消息。This is a message. 6这是一条消息。This is a message. 7这是一条消息。This is a message. 8这是一条消息。This is a message. 9这是一条消息。This is a message. 10这是一条消息。 11这是一条消息。★★★"
                                           , icon: Properties.Resources.clear);
            textBoxX1.Text = $"{result}";
        }

        private void btnErrorDialog_Click(object sender, EventArgs e)
        {
            Exception exception = null;
            try
            {
                using (var fs = File.OpenRead(@"D:\\text.txt"));
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            textBoxX1.Clear();
            var result = MsgBox.ShowError(exception);
            textBoxX1.Text = $"{result}";
        }





        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            new Form2().Show(this);
        }

        private void btnShowForm3_Click(object sender, EventArgs e)
        {
            new Form3().Show(this);
        }

        private void btnShowForm4_Click(object sender, EventArgs e)
        {
            new Form4().Show(this);
        }
    }
}
