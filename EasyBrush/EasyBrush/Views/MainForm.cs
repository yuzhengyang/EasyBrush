using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace EasyBrush.Views
{
    public partial class MainForm : Form
    {
        private bool startdraw = false;
        private Graphics g;
        private Pen pen;
        private Point startpt;
        Color color = Color.Red;
        Bitmap bitmap = null;

        DrawForm DrawForm = new DrawForm();
        CanvasForm CanvasForm = new CanvasForm();
        public MainForm()
        {
            InitializeComponent();
            TopMost = true;
            StartPosition = FormStartPosition.CenterScreen;
            RegisterHotKey(Handle, 100, KeyModifiers.Shift, Keys.S);
            RegisterHotKey(Handle, 101, KeyModifiers.Shift, Keys.C);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CanvasForm.Show();

            DrawForm.MouseDown += DrawForm_MouseDown;
            DrawForm.MouseMove += DrawForm_MouseMove;
            DrawForm.MouseUp += DrawForm_MouseUp;

            bitmap = new Bitmap(CanvasForm.Width, CanvasForm.Height);
            g = Graphics.FromImage(bitmap);
            pen = new Pen(color, 3f);
        }

        private void BTDraw_Click(object sender, EventArgs e)
        {
            DrawForm.Show();
        }
        #region 绘制
        private void DrawForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startdraw = true;
                startpt = e.Location;
            }
        }

        private void DrawForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (startdraw)
            {
                g.DrawLine(pen, startpt, e.Location);
                startpt = e.Location;
                CanvasForm.SetImage(bitmap);
            }
        }

        private void DrawForm_MouseUp(object sender, MouseEventArgs e)
        {
            startdraw = false;
        }
        #endregion
        #region 快捷键
        //======================================
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
  IntPtr hWnd,                //要定义热键的窗口的句柄
             int id,                     //定义热键ID（不能与其它ID重复）           
             KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
             Keys vk                     //定义热键的内容
             );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
        IntPtr hWnd,                //要取消热键的窗口的句柄
                   int id                      //要取消热键的ID
                   );
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }

        //=======================================
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            if (!DrawForm.TopMost)
                            {
                                DrawForm.TopMost = true;
                                DrawForm.Show();
                            }
                            else
                            {

                                DrawForm.TopMost = false;
                                DrawForm.Hide();
                            }
                            break;
                        case 101:
                            //Clear();
                            break;

                    }
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion
    }
}
