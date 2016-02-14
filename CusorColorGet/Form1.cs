using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CusorColorGet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Color c = GetCursorColor();
            C1_label.BackColor = c;
            C1Text_label.Text = "#" + c.Name.ToUpper().Substring(2,6);
        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point lpPoint);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);
        static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public static Color GetColorAt(Point location) {
            using (Graphics gdest = Graphics.FromImage(screenPixel)) {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero)) {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();

                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        public static Color GetCursorColor() {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            return GetColorAt(cursor);
        }

        private void dragimg_label_MouseDown(object sender, MouseEventArgs e) {
            this.Cursor = Cursors.Cross;
        }

        private void dragimg_label_MouseUp(object sender, MouseEventArgs e) {
            Point cursor = new Point();
            GetCursorPos(ref cursor);
            var c = GetColorAt(cursor);
            C_tb.Text = "#" + c.Name.ToUpper().Substring(2, 6);
            C2_label.BackColor = c;
            this.Cursor = Cursors.Default;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel1.Visible = true;
            System.Diagnostics.Process.Start("http://darkautism.blogspot.tw/");  
        }
    }
}
