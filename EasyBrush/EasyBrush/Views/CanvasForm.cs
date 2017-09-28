using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Y.Utils.WindowsUtils.APIUtils;

namespace EasyBrush.Views
{
    public partial class CanvasForm : Form
    {
        const double CanvasOpacity = 1;
        public CanvasForm()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            TopMost = true;
            ShowInTaskbar = false;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }

        private void CanvasForm_Load(object sender, EventArgs e)
        {
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.ExStyle |= 0x00080000; // WS_EX_LAYERED
                return cParms;
            }
        }
        public void SetImage(Image image, double opacity = CanvasOpacity)
        {
            if (image != null)
            {
                //绘制绘图层背景
                Bitmap bitmap = new Bitmap(image, base.Width, base.Height);
                if (!Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat))
                    throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
                IntPtr oldBits = IntPtr.Zero;
                IntPtr screenDC = FormStyleAPI.GetDC(IntPtr.Zero);
                IntPtr hBitmap = IntPtr.Zero;
                IntPtr memDc = FormStyleAPI.CreateCompatibleDC(screenDC);

                try
                {
                    FormStyleAPI.Point topLoc = new FormStyleAPI.Point(Left, Top);
                    FormStyleAPI.Size bitMapSize = new FormStyleAPI.Size(Width, Height);
                    FormStyleAPI.BLENDFUNCTION blendFunc = new FormStyleAPI.BLENDFUNCTION();
                    FormStyleAPI.Point srcLoc = new FormStyleAPI.Point(0, 0);

                    hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                    oldBits = FormStyleAPI.SelectObject(memDc, hBitmap);

                    blendFunc.BlendOp = FormStyleAPI.AC_SRC_OVER;
                    blendFunc.SourceConstantAlpha = Byte.Parse(((int)(CanvasOpacity * 255)).ToString());
                    blendFunc.AlphaFormat = FormStyleAPI.AC_SRC_ALPHA;
                    blendFunc.BlendFlags = 0;

                    FormStyleAPI.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, FormStyleAPI.ULW_ALPHA);
                }
                finally
                {
                    if (hBitmap != IntPtr.Zero)
                    {
                        FormStyleAPI.SelectObject(memDc, oldBits);
                        FormStyleAPI.DeleteObject(hBitmap);
                    }
                    FormStyleAPI.ReleaseDC(IntPtr.Zero, screenDC);
                    FormStyleAPI.DeleteDC(memDc);
                    bitmap.Dispose();
                }
            }
        }
        ///// <summary>
        ///// 设置无标题窗口可拖动
        ///// </summary>
        ///// <param name="e"></param>
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        FormStyleAPI.ReleaseCapture();
        //        FormStyleAPI.SendMessage(Handle, FormStyleAPI.WM_NCLBUTTONDOWN, FormStyleAPI.HTCAPTION, 0);
        //    }
        //}
        #region 窗体穿透
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );
        /// <summary> 
        /// 设置窗体具有鼠标穿透效果 
        /// </summary> 
        public void SetPenetrate()
        {
            this.TopMost = true;
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        }
        #endregion
    }
}
