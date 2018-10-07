using Azylee.Core.FormUtils;
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

        public static Bitmap Canvas = null;

        public static FormManTool FormMan = new FormManTool();

        public class MyPen
        {
            public static Pen Pen = null;
            public static float Width = 5f;
            public static int Alpha = 255;
            public static Color Color = Color.Red;
            public static void Set()
            {
                Pen = new Pen(Color.FromArgb(Alpha, Color), Width);
            }
        }


        public class Forms
        {
            /// <summary>
            /// 控制主界面
            /// </summary>
            public static MainForm Main = null;
            /// <summary>
            /// 展示界面
            /// </summary>
            public static CanvasForm Canvas = new CanvasForm();
            /// <summary>
            /// 绘图界面
            /// </summary>
            public static DrawForm Draw = new DrawForm();
        }
    }
}
