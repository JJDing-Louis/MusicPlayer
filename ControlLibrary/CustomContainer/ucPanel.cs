using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary.CustomContainer
{
    public partial class ucPanel : Panel
    {
        #region 欄位
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        #endregion 欄位

        #region 屬性
        /// <summary>
        /// 邊緣導角
        /// </summary>
        [Category("自訂樣式")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 漸層色的角度
        /// </summary>
        [Category("自訂樣式")]
        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 漸層色的上部顏色
        /// </summary>
        [Category("自訂樣式")]
        public Color GradientTopColor
        {
            get
            {
                return gradientTopColor;
            }

            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 漸層色的下部顏色
        /// </summary>
        [Category("自訂樣式")]
        public Color GradientBottomColor
        {
            get
            {
                return gradientBottomColor;
            }

            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }
        #endregion 屬性

        #region 建構子
        public ucPanel()
        {
            //InitializeComponent();
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }
        #endregion 建構子

        #region 私有方法
        private GraphicsPath GetucPath(RectangleF rectangle, float radius) 
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            //右下
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            //左下
            graphicsPath.AddArc(rectangle.X , rectangle.Height - radius, radius, radius, 90, 90);
            //左上
            graphicsPath.AddArc(rectangle.X,rectangle.Y, radius, radius, 180, 90);
            //右上
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            return graphicsPath;
        }
        #endregion 私有方法

        #region 可複寫方法

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetucPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else
                this.Region = new Region(rectangleF);
        }

        #endregion 可複寫方法

    }
}
