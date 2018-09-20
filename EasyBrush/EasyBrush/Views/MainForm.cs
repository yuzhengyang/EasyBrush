using EasyBrush.Commons;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Azylee.Core.WindowsUtils.APIUtils.WindowsHotKeyAPI;

namespace EasyBrush.Views
{
    public partial class MainForm : Form
    {
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
        }

        /// <summary>
        /// 支持快捷键
        /// </summary>
        /// <param name="m"></param>
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

        private void BTClear_Click(object sender, EventArgs e)
        {
            R.Forms.Draw.Clear();
        }

        //private void PBColorBox_Click(object sender, EventArgs e)
        //{
        //    if (colorDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        R.Color = colorDialog1.Color;
        //        R.Pen = new Pen(Color.FromArgb(255, R.Color), 3f);
        //        PBColorBox.BackColor = R.Color;
        //    }
        //}

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = new Bitmap(BackgroundImage);
            R.Color = bitmap.GetPixel(e.X, e.Y);
            R.Pen = new Pen(Color.FromArgb(255, R.Color), 3f);

            R.Forms.Draw.Drawing(true);
        }
    }
}
