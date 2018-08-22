using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayUniformityApp
{
    public partial class formOutline : Form
    {
        private Bitmap ShowOutlineImg, DisplayImg;
        private PctbxControl pctbxCtrl = new PctbxControl();
        public formOutline(Bitmap ShowProfileImg)
        {
            InitializeComponent();
            ShowOutlineImg = ShowProfileImg;
            DisplayImg = ShowOutlineImg.Clone(new Rectangle(0, 0, ShowOutlineImg.Width, ShowOutlineImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            pctbxCtrl = new PctbxControl(DisplayImg);
        }

        private void formOutline_Load(object sender, EventArgs e)
        {
            pctOrigImg.Image = DisplayImg;
        }

        private bool profileFlag;



        private void chkProfile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProfile.Checked)
                profileFlag = true;
            else
            {
                profileFlag = false;

                DisplayImg = ShowOutlineImg.Clone(new Rectangle(0, 0, ShowOutlineImg.Width, ShowOutlineImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                pctbxCtrl.ZoomPicture(DisplayImg, pctOrigImg, 0, new Point(-1, -1));
            }

        }

        #region picture box, pctOrigImg, control
        Bitmap PreHorImg, PreVerImg;
        Point StartPoint, ShowOutlinePos;
        ShowData showProfile = new ShowData();
        private void pctOrigImg_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (profileFlag == true)
                {
                    //ShowOutlinePos = new Point(e.X, e.Y);
                    DisplayImg = ShowOutlineImg.Clone(new Rectangle(0, 0, ShowOutlineImg.Width, ShowOutlineImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    Point CurrentPoint = new Point(e.X, e.Y);
                    Point RealPosition = new Point(0, 0);
                    pctbxCtrl.CoordinateAfterZoom(ref RealPosition, CurrentPoint);
                    ShowOutlinePos = RealPosition;

                    Graphics g = Graphics.FromImage(DisplayImg);
                    float[] dashValue = { 5, 2, 5, 2 };
                    System.Drawing.Pen pen = new Pen(System.Drawing.Color.Red, 16);
                    pen.DashPattern = dashValue;
                    g.DrawLine(pen, new Point(RealPosition.X, 0), new Point(RealPosition.X, DisplayImg.Height));
                    pen = new Pen(System.Drawing.Color.Blue, 16);
                    pen.DashPattern = dashValue;
                    g.DrawLine(pen, new Point(0, RealPosition.Y), new Point(DisplayImg.Width, RealPosition.Y));

                    pctbxCtrl.MovePicture(DisplayImg, pctOrigImg, CurrentPoint, StartPoint);
                    // drawing profile:
                    // I only draw profile of single channel image.
                    // I will research drawing profile of multiple channels image. 
                    double zoomRatio;
                    zoomRatio = pctbxCtrl.get_ZoomRatio();
                    Point LeftTop = pctbxCtrl.get_LeftTopPoint();
                    showProfile.ShowHorProfile(ShowOutlineImg, zoomRatio, LeftTop, RealPosition.Y, pctOrigImg.Width, pctHorOutline);
                    PreHorImg = showProfile.GetHorProfileImg();
                    showProfile.ShowVerProfile(ShowOutlineImg, zoomRatio, LeftTop, RealPosition.X, pctOrigImg.Height, pctVerOutline);
                    PreVerImg = showProfile.GetVerProfileImg();
                }
            }
            catch (Exception err)
            {
                ScLib.Log log = new ScLib.Log();
                log.WriteLog(err.Message);
            }
        }

        private void pctOrigImg_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void pctOrigImg_MouseMove(object sender, MouseEventArgs e)
        {
            Point CurrentPoint = new Point(e.X, e.Y);
            Point RealPosition = new Point(0, 0);

            if (e.Button == System.Windows.Forms.MouseButtons.Left && DisplayImg != null && (StartPoint.X != 0 && StartPoint.Y != 0))
            {
                pctbxCtrl.MovePicture(DisplayImg, pctOrigImg, CurrentPoint, StartPoint);
                StartPoint.X = e.X;
                StartPoint.Y = e.Y;
            }
        }

        private void pctVerOutline_MouseMove(object sender, MouseEventArgs e)
        {
            if (profileFlag == true && pctHorOutline.Image != null)
            {
                Point CurrentPoint = new Point(e.X, e.Y);
                int x, y; // convert to real position of ShowOutlineImg
                double zoomRatio;
                zoomRatio = pctbxCtrl.get_ZoomRatio();
                Point LeftTop = pctbxCtrl.get_LeftTopPoint();
                y = Convert.ToInt16((e.Y - LeftTop.Y) / zoomRatio);
                if (y <= 0)
                    y = 0;
                else if (y >= ShowOutlineImg.Height)
                    y = ShowOutlineImg.Height;

                // draw two lines cross in profile and show x, gray value
                Bitmap RowOutlineImg = PreVerImg.Clone(new Rectangle(0, 0, PreVerImg.Width, PreVerImg.Height), PreVerImg.PixelFormat);

                Graphics g = Graphics.FromImage(RowOutlineImg);
                float[] dashValue = { 3, 2, 3, 2 };
                System.Drawing.Pen pen = new Pen(System.Drawing.Color.Black, (float)(0.5));
                pen.DashPattern = dashValue;
                g.DrawLine(pen, new Point(0, CurrentPoint.Y), new Point(DisplayImg.Width, CurrentPoint.Y));

                float grayValue = (ShowOutlineImg.GetPixel(ShowOutlinePos.X, y).R + ShowOutlineImg.GetPixel(ShowOutlinePos.X, y).G + ShowOutlineImg.GetPixel(ShowOutlinePos.X, y).B) / 3;
                x = Convert.ToInt16((1.0 - (grayValue / 255.0)) * pctVerOutline.Width); // 
                g.DrawLine(pen, new Point(x, 0), new Point(x, DisplayImg.Height));

                g.DrawString("(x, y) = (" + x.ToString() + "," + y.ToString() + "), gray = " + grayValue.ToString(),
                    new Font(this.Font, FontStyle.Bold), Brushes.Black, new PointF(x, CurrentPoint.Y));
                pctVerOutline.Image = RowOutlineImg;
            }
        }

        private void pctHorOutline_MouseMove(object sender, MouseEventArgs e)
        {
            if (profileFlag == true && pctHorOutline.Image != null)
            {
                Point CurrentPoint = new Point(e.X, e.Y);
                int x, y; // convert to real position of ShowOutlineImg
                double zoomRatio;
                zoomRatio = pctbxCtrl.get_ZoomRatio();
                Point LeftTop = pctbxCtrl.get_LeftTopPoint();
                x = Convert.ToInt16((e.X - LeftTop.X) / zoomRatio);
                if (x <= 0)
                    x = 0;
                else if(x >= ShowOutlineImg.Width)
                    x = ShowOutlineImg.Width;

                // draw two lines cross in profile and show x, gray value
                Bitmap ColOutlineImg = PreHorImg.Clone(new Rectangle(0, 0, PreHorImg.Width, PreHorImg.Height), PreHorImg.PixelFormat);
                
                Graphics g = Graphics.FromImage(ColOutlineImg);
                float[] dashValue = { 3, 2, 3, 2 };
                System.Drawing.Pen pen = new Pen(System.Drawing.Color.Black, (float)(0.5));
                pen.DashPattern = dashValue;
                g.DrawLine(pen, new Point(CurrentPoint.X, 0), new Point(CurrentPoint.X, DisplayImg.Height));

                float grayValue = (ShowOutlineImg.GetPixel(x, ShowOutlinePos.Y).R + ShowOutlineImg.GetPixel(x, ShowOutlinePos.Y).G + ShowOutlineImg.GetPixel(x, ShowOutlinePos.Y).B) / 3;
                y = Convert.ToInt16((1.0 - (grayValue / 255.0)) * pctHorOutline.Height); // 
                g.DrawLine(pen, new Point(0, y), new Point(DisplayImg.Width, y));

                g.DrawString("(x, y) = (" + x.ToString() + "," + y.ToString() + "), gray = " + grayValue.ToString(),
                    new Font(this.Font, FontStyle.Bold), Brushes.Black, new PointF(CurrentPoint.X, y));
                pctHorOutline.Image = ColOutlineImg;
            }
        }

        private void pctOrigImg_MouseWheel(object sender, MouseEventArgs e)
        {
            if (DisplayImg != null)
            {
                Point CurrentMousePos = new Point(e.X, e.Y);

                pctbxCtrl.ZoomPicture(DisplayImg, pctOrigImg, e.Delta, CurrentMousePos);
            }
        }
        #endregion picture box, pctOrigImg, control


    }
}
