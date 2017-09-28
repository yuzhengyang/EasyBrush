using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Y.Skin.YoForm.NoTitle;

namespace EasyBrush.Views
{
    public partial class WelcomeForm : NoTitleForm
    {
        bool IsShow = true;
        double ShowStep = 0.01;
        int ShowInterval = 15;
        public WelcomeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            ShowInTaskbar = false;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            TMAnimShowAndHide.Interval = ShowInterval;
            TMAnimShowAndHide.Enabled = true;
        }

        private void TMAnimShowAndHide_Tick(object sender, EventArgs e)
        {
            if (IsShow)
            {
                //显示启动界面
                if (Opacity < 1) { Opacity += ShowStep; }
                else { IsShow = false; }
            }
            else
            {
                //隐藏启动界面
                if (Opacity > 0) { Opacity -= ShowStep; }
                else { TMAnimShowAndHide.Enabled = false; Close(); }
            }
        }
    }
}
