using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public class ControlBtn
    {
        static bool isMax, isFull = false;
        static Point oldLocation, defaultLocation;
        static Size oldSize, defaultSize;

        static void OperationFullScreen(Form form) 
        {
            form.WindowState = (form.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        static void OperationMaxmize(Form form) 
        {
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
        }

        /// <summary>
        /// this method  should fire when app starts
        /// </summary>
        /// <param name="form"></param>
        public static void SetDefault(Form form) 
        {
            oldLocation = form.Location;
            oldSize = defaultSize=form.Size;
        }

        /// <summary>
        /// 放大最大的方法
        /// </summary>
        /// <param name="form"></param>
        /// <param name="button"></param>
        public static void Maximize(Form form, Button button) 
        {
            //如果螢幕狀態，非放到最大，就放到最大
            if (isMax==false) 
            {
                oldLocation = new Point(form.Location.X, form.Location.Y);
                oldSize = new Size(form.Size.Width, form.Size.Height);
                OperationMaxmize(form);
                isFull = false;
                isMax = true;
            }
            //否則，回到正常狀態
            else
            {
                if (oldSize.Width>=SystemInformation.WorkingArea.Width|oldSize.Height>= SystemInformation.WorkingArea.Height)
                {
                    form.Location = defaultLocation;
                    form.Size = defaultSize;
                }
                else
                {
                    form.Location = oldLocation;
                    form.Size = oldSize;
                }
                isMax = isFull = false;
            }        
        }

        /// <summary>
        /// 全螢幕
        /// </summary>
        /// <param name="form"></param>
        public static void FullScreen(Form form) 
        {
            if (isFull == false)
            {
                oldLocation = new Point(form.Location.X, form.Location.Y);
                oldSize = new Size(form.Size.Width, form.Size.Height);
                OperationFullScreen(form);
                isFull = false;
                isMax = true;
            }
            else
            {
                if (oldSize.Width >= SystemInformation.WorkingArea.Width | oldSize.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = defaultLocation;
                    form.Size = defaultSize;
                }
                else
                {
                    form.Location = oldLocation;
                    form.Size = oldSize;
                }
                isMax = isFull = false;
            }

        }

        /// <summary>
        /// 縮到最小的方法
        /// </summary>
        /// <param name="form"></param>
        public static void Minimize(Form form) 
        {
            form.WindowState = (form.WindowState == FormWindowState.Minimized) ? FormWindowState.Normal : FormWindowState.Minimized;
        }
        
        /// <summary>
        /// 關閉程式的方法 (如果是子母視窗，可能要改一下控制)
        /// </summary>
        public static void Exit() 
        {
            Application.Exit();
        }
    }
}
