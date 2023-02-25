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
    public partial class ucCircularProgressBar : UserControl
    {
        #region 欄位
        float value = 40;
        int borderSize = 15;
        Color middleCircleColor = Color.DarkBlue;
        Color outerCircleColor = Color.Transparent;
        #endregion 欄位

        #region 屬性
        //[Category("自訂樣式")]
        //分類待修正
        //須補敘述
        public float Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = (value > 100) ? 100 : value; Invalidate();
            }
        }
        [Category("自訂樣式")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = (value > 20) ? 20: value;
                Invalidate();
            }
        }
        [Category("自訂樣式")]
        public Color MiddleCircleColor
        {
            get
            {
                return middleCircleColor;
            }

            set
            {
                middleCircleColor =ForeColor= value;
                Invalidate();
            }
        }
        [Category("自訂樣式")]
        public Color OuterCircleColor
        {
            get
            {
                return outerCircleColor;
            }

            set
            {
                outerCircleColor = value;
                Invalidate();
            }
        }
        #endregion 屬性

        #region 建構子
        public ucCircularProgressBar()
        {
            DoubleBuffered = true;
        }
        #endregion 建構子

        #region 覆寫方法
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen Backpen = new Pen(Color.White,BorderSize-1);
            Pen pen = new Pen(middleCircleColor, BorderSize - 1) { StartCap=LineCap.Round,EndCap = LineCap.Round};
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            graphics.FillPie(new SolidBrush(outerCircleColor), new Rectangle(10, 10, Width - 20, Height - 20), 0, 360);
            graphics.DrawArc(Backpen, new Rectangle(10, 10, Width - 20, Height - 20), -90, 360);
            graphics.DrawArc(pen, new Rectangle(10, 10, Width - 20, Height - 20), -90,(Value/100)* 360);

            StringFormat stringFormat = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            graphics.DrawString(Value + "%", Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);
            base.OnPaint(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Height = Width;
            base.OnSizeChanged(e);
        }
        #endregion 覆寫方法
    }
}
