using EasyBrush.Commons;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EasyBrush.Views
{
    public partial class DrawForm : Form
    {
        public bool IsPenDown = false;
        public bool IsDrawing = false;
        private Graphics Gra;
        private Point StartPoint;

        public DrawForm()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Opacity = 0.01;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {
            R.Canvas = new Bitmap(Width, Height);
            Gra = Graphics.FromImage(R.Canvas);
            Gra.SmoothingMode = SmoothingMode.AntiAlias;
            R.MyPen.Set();
        }
        public void Drawing(bool isDraw)
        {
            IsDrawing = isDraw;
            R.Forms.Canvas.Show();
            if (isDraw)
            {
                R.Forms.Draw.TopMost = true;
                R.Forms.Draw.Show();
                R.Forms.Main.WindowState = FormWindowState.Minimized;
                Activate();
            }
            else
            {
                R.Forms.Draw.TopMost = false;
                R.Forms.Draw.Hide();
                R.Forms.Main.WindowState = FormWindowState.Normal;
                R.Forms.Main.Activate();
            }
        }

        private void DrawForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsPenDown = true;
                StartPoint = e.Location;
                R.Forms.Canvas.SetImage(R.Canvas);
                R.Forms.Draw.Drawing(true);
            }
            else if (e.Button == MouseButtons.Right)
            {
                R.Forms.Draw.Drawing(false);
            }
        }

        private void DrawForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPenDown)
            {
                Gra.DrawLine(R.MyPen.Pen, StartPoint, e.Location);
                StartPoint = e.Location;
                R.Forms.Canvas.SetImage(R.Canvas);
            }
        }

        private void DrawForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsPenDown = false;
        }
        public void Clear()
        {
            Gra?.Clear(Color.FromArgb(0, Color.White));
            R.Forms.Canvas.SetImage(R.Canvas);
        }

        private void DrawForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                R.Forms.Draw.Drawing(false);
            }
        }

        private void DrawForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
