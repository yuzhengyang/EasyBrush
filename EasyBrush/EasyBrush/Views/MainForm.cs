using Azylee.WinformSkin.FormUI.NoTitle;
using EasyBrush.Commons;
using System;
using System.Drawing;
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
            Text = $"{Text}  [{Application.ProductVersion}]";
            TopMost = true;

            R.MyPen.Set();
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
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NIMain.Visible = false;
            Close();
        }

        private void 绘画ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Drawing(true);
        }

        private void 清屏ToolStripMenuItem_Click(object sender, EventArgs e)
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
            NIMain.Visible = false;
            FormClosing -= MainForm_FormClosing;

            try { Application.Exit(); } catch { }
            try { Environment.Exit(Environment.ExitCode); } catch { }
        }
        private void NIMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }
        #endregion

        #region 画笔粗细、透明度设置
        private void RBPenWidthThin_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenWidthThin.Checked)
            {
                R.MyPen.Width = 5f;
                R.MyPen.Set();
            }
        }

        private void RBPenWidthMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenWidthMiddle.Checked)
            {
                R.MyPen.Width = 10f;
                R.MyPen.Set();
            }
        }

        private void RBPenWidthLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenWidthLarge.Checked)
            {
                R.MyPen.Width = 15f;
                R.MyPen.Set();
            }
        }

        private void RBPenAlphaNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenAlphaNo.Checked)
            {
                R.MyPen.Alpha = 255;
                R.MyPen.Set();
            }
        }

        private void RBPenAlphaLow_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenAlphaLow.Checked)
            {
                R.MyPen.Alpha = (int)(255 - (255 * 0.2));
                R.MyPen.Set();
            }
        }

        private void RBPenAlphaMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenAlphaMiddle.Checked)
            {
                R.MyPen.Alpha = (int)(255 - (255 * 0.4));
                R.MyPen.Set();
            }
        }

        private void RBPenAlphaHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPenAlphaHigh.Checked)
            {
                R.MyPen.Alpha = (int)(255 - (255 * 0.6));
                R.MyPen.Set();
            }
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
    }
}
