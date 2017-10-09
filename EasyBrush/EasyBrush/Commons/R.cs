using EasyBrush.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace EasyBrush.Commons
{
    public class R
    {
        public static Pen Pen = null;
        public static Bitmap Canvas = null;
        public static Color Color = Color.Red;
        public class Forms
        {
            public static MainForm Main = null;
            public static CanvasForm Canvas = new CanvasForm();
            public static DrawForm Draw = new DrawForm();
        }
    }
}
