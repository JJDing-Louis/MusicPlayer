using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary.CustomController
{
    public class ucRoundButton : Button
    {
        #region 私有欄位
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.DodgerBlue;
        #endregion 私有欄位

        #region 公開屬性
        [Category("自訂樣式")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("自訂樣式")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = ( value<=Height)?value:Height;
                Invalidate();
            }
        }
        [Category("自訂樣式")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        [Category("自訂樣式")]
        public Color BackgroudColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
        [Category("自訂樣式")]
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }
        #endregion 公開屬性

        #region 建構子
        public ucRoundButton()
        {
            Size = new Size(200, 100);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;

            Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height) borderRadius = Height;
        }
        #endregion 建構子

        #region 私有方法
        private GraphicsPath GetFigurePath(RectangleF rectangle, float radius) 
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            //左上
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            //右上
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            //右下
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            //左下
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;            
        }




        #endregion 私有方法

        #region 覆寫方法
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectangleSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, Width - 0.5F, Height - 1);
            if (borderRadius > 1)
            {
                using (GraphicsPath graphicsPathSurface = GetFigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath graphicsPathBorder = GetFigurePath(rectangleBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(graphicsPathSurface);
                    pevent.Graphics.DrawPath(penBorder, graphicsPathSurface);
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, graphicsPathBorder);
                }
            }
            else
            {
                Region = new Region(rectangleSurface);
                if (borderSize >= 1)
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
            }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode) Invalidate();
        }
        #endregion 覆寫方法
    }
}
