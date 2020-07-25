using Azylee.Core.DataUtils.DateTimeUtils;
using Azylee.Core.DrawingUtils.ImageUtils;
using Azylee.Core.IOUtils.DirUtils;
using Azylee.Core.ThreadUtils.SleepUtils;
using Azylee.Core.WindowsUtils.BrowserUtils;
using Azylee.WinformSkin.FormUI.Toast;
using EasyBrush.Commons;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azylee.Core.WindowsUtils.APIUtils.WindowsHotKeyAPI;

namespace EasyBrush.Views
{
    public partial class MainForm : Form
    {
        #region 窗体事件
        public MainForm()
        {
            InitializeComponent();
            R.Forms.Main = this;
            StartPosition = FormStartPosition.CenterScreen;
            RegisterHotKey(Handle, 100, KeyModifiers.Shift, Keys.A);
            RegisterHotKey(Handle, 101, KeyModifiers.Shift, Keys.C);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TopMost = true;

            R.MyPen.Set();

            // 窗口靠左侧显示
            Left = 0;

            // 初始化画笔粗细和透明度选择器
            CBPenWidth.SelectedIndex = 0;
            CBPenAlpha.SelectedIndex = 0;
        }
        #endregion

        #region 按钮事件
        private void BTClear_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Clear();
        }

        private void BTDraw_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Drawing(true);
        }
        #endregion

        #region 菜单功能

        private void 保存屏幕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap screen = null;
            try
            {
                string file = DirTool.Combine(R.Paths.App, DateTimeConvert.CompactString(DateTime.Now) + ".jpg");
                screen = ScreenCapture.Capture();
                screen.Save(file, System.Drawing.Imaging.ImageFormat.Jpeg);
                ToastForm.Display("保存", "保存屏幕成功：" + Path.GetFileName(file), ToastForm.ToastType.info);
            }
            catch { ToastForm.Display("保存", "保存屏幕失败", ToastForm.ToastType.error); }
            finally
            {
                screen?.Dispose();
            }
        }
        private void 发送反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R.FormMan.GetUnique<QuestionnaireForm>().Show();
        }
        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R.FormMan.GetUnique<HelpForm>().Show();
        }
        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/yuzhengyang/EasyBrush";
            bool _flag = false;
            if (BrowserSelector.ModernBrowser(out string browser))
            {
                try
                {
                    Process.Start(browser, $"{url}");
                    _flag = true;
                }
                catch { }
            }
            if (_flag == false) try { Process.Start($"{url}"); } catch { }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NIMain.Visible = false;
            ExitApp();
        }
        #endregion

        #region 工具栏
        private void TSLDraw_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Drawing(true);
        }
        private void TSLClean_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Clear();
        }
        #endregion

        #region 色板选色
        private void PNColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Bitmap bitmap = new Bitmap(PNColor.BackgroundImage);
                R.MyPen.Color = bitmap.GetPixel(e.X, e.Y);
                R.MyPen.Set();

                R.Forms.Draw.Drawing(true);
            }
        }
        #endregion

        #region 支持快捷键
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            if (!R.Forms.Draw.IsDrawing)
                            {
                                R.Forms.Draw.Drawing(true);
                            }
                            else
                            {
                                R.Forms.Draw.Drawing(false);
                            }
                            break;
                        case 101:
                            R.Forms.Draw.Clear();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        #endregion

        #region 右下角图标事件
        private void 主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitApp();
        }
        private void NIMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }
        #endregion

        #region 画笔粗细、透明度设置

        private void CBPenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    R.MyPen.Width = 5f;
                    break;
                case 1:
                    R.MyPen.Width = 10f;
                    break;
                case 2:
                    R.MyPen.Width = 15f;
                    break;
                default: break;
            }
            R.MyPen.Set();
        }
        private void CBPenAlpha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    R.MyPen.Alpha = 255;
                    break;
                case 1:
                    R.MyPen.Alpha = (int)(255 - (255 * 0.2));
                    break;
                case 2:
                    R.MyPen.Alpha = (int)(255 - (255 * 0.4));
                    break;
                case 3:
                    R.MyPen.Alpha = (int)(255 - (255 * 0.6));
                    break;
                default: break;
            }
            R.MyPen.Set();
        }
        #endregion

        #region MyRegion
        /// <summary>
        /// 隐藏窗口
        /// </summary>
        private void HideForm()
        {
            Opacity = 0;
            ShowInTaskbar = false;
            Hide();
        }
        /// <summary>
        /// 显示窗口
        /// </summary>
        private void ShowForm()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideForm();
            switch (e.CloseReason)
            {
                case CloseReason.None:
                    e.Cancel = true;
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                case CloseReason.MdiFormClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.TaskManagerClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.FormOwnerClosing:
                    e.Cancel = true;
                    break;
                case CloseReason.ApplicationExitCall:
                    break;
            }
        }
        #endregion

        #region 退出程序

        public void ExitApp()
        {
            //隐藏窗口图标
            try
            {
                Invoke(new Action(() =>
                {
                    NIMain.Visible = false;
                    FormClosing -= MainForm_FormClosing;
                    Close();

                    try { Application.Exit(); } catch { }
                    try { Environment.Exit(Environment.ExitCode); } catch { }
                }));
            }
            catch { }

            //退出及强制退出
            Task.Factory.StartNew(() =>
            {
                Sleep.S(2);
                //延迟结束进程
                Azylee.Core.ProcessUtils.ProcessTool.SleepKill(Process.GetCurrentProcess(), 3);
            });
        }
        #endregion

    }
}
