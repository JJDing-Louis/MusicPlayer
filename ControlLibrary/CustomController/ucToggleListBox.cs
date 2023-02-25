using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlLibrary
{
    public class ucToggleListBox : CheckedListBox
    {
        private Color offBackColor = Color.Gray;

        private Color offToggleColor = Color.Gainsboro;

        //Fields
        private Color onBackColor = Color.MediumSlateBlue;

        private Color onToggleColor = Color.WhiteSmoke;
        private bool solidStyle = true;

        /// <summary>
        /// 建構子
        /// </summary>
        public ucToggleListBox()
        {
        }
    }
}
