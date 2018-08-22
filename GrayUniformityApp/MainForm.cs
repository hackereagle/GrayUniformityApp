using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CVision;

namespace GrayUniformityApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string ImagePath;
        Bitmap SrcImg, DisplayImg;
        PctbxControl pctbxCtrl = new PctbxControl();
        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            openImgDialog.Filter = "JPEG檔|*.jpg*|BMP檔|*.bmp*|TIFF檔|*.tiff|PNG檔|*.png*";
            openImgDialog.RestoreDirectory = true;
            openImgDialog.FilterIndex = 2;
            if (openImgDialog.ShowDialog() == DialogResult.OK)
            {
                label_FileName.Visible = true;
                label_FileName.Text = openImgDialog.FileName;

                ImagePath = openImgDialog.FileName;
                SrcImg = new Bitmap(openImgDialog.FileName);
                DisplayImg = SrcImg.Clone(new Rectangle(0, 0, SrcImg.Width, SrcImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                pctbx_Display.Image = DisplayImg;

                pctbxCtrl = new PctbxControl(DisplayImg);
            }
        }

        public Bitmap[] RoiImage;
        private void btn_DrawWin_Click(object sender, EventArgs e)
        {
            if (DisplayImg == null)
            {
                return;
            }
            else
            {
                DisplayImg = SrcImg.Clone(new Rectangle(0, 0, SrcImg.Width, SrcImg.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                int WinNum, WinSize, WinsHorInterval, WinsVerInterval, x, y;
                WinNum = Convert.ToInt16(txtWinNum.Text);
                WinSize = Convert.ToInt16(txtWinSize.Text);
                WinsHorInterval = Convert.ToInt16(txtWinsHorInterval.Text);
                WinsVerInterval = Convert.ToInt16(txtWinsVerInterval.Text);
                x = Convert.ToInt16(txt1WinX.Text);
                y = Convert.ToInt16(txt1WinY.Text);

                if ((x + WinsHorInterval * 2 + 3 * WinSize) < SrcImg.Width &&
                    (y + WinsVerInterval * 2 + 3 * WinSize) < SrcImg.Height)
                {
                    int k = 0;
                    RoiImage = new Bitmap[WinNum];
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            Rectangle ROI = new Rectangle(x + i * WinSize + i * WinsHorInterval,
                                y + j * WinSize + j * WinsVerInterval, WinSize, WinSize);
                            RoiImage[k] = SrcImg.Clone(ROI, SrcImg.PixelFormat);

                            Graphics g = System.Drawing.Graphics.FromImage(DisplayImg);
                            Pen pen = new Pen(Color.Red); // 以後寬度也要算
                            Rectangle Roi = new Rectangle(x + i * WinSize + i * WinsHorInterval, y + j * WinSize + j * WinsVerInterval,
                                WinSize, WinSize);
                            g.DrawRectangle(pen, Roi);

                            System.Drawing.Font drawFont = new Font("Times New Romance", 16);
                            System.Drawing.SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Red);
                            g.DrawString((k + 1).ToString(), drawFont, drawBrush, x + i * WinSize + i * WinsHorInterval, y + j * WinSize + j * WinsVerInterval);
                            k++;
                            
                        }

                    pctbxCtrl.ZoomPicture(DisplayImg, pctbx_Display, 0, new Point(-1, -1));
                }
                else
                {
                    MessageBox.Show("That will has recipe out of figure!", "Warning!");
                }
            }
            
        }

        private void btnConduct_Click(object sender, EventArgs e)
        {
            VisionResult[] result = new VisionResult[Convert.ToInt16(txtWinNum.Text)];
            ImgParam roiInfo;
            if (RoiImage == null)
            {
                MessageBox.Show("Please Draw ROI before calculating mean gray!");
            }
            else
            {
                if (SrcImg.PixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
                {
                    ImgProc proc = new ImgProc();
                    ShowData showInfo = new ShowData();
                    int i = 0;
                    foreach (Bitmap ROI in RoiImage)
                    {
                        unsafe
                        {
                            System.Drawing.Imaging.BitmapData ptr = ROI.LockBits(new Rectangle(0, 0, ROI.Width, ROI.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
                            roiInfo.Width = ROI.Width;
                            roiInfo.Height = ROI.Height;

                            //傳給C++/open cv算，然後用ShowData把結果show在grid上
                            // 傳結構的寫法
                            //ImageConverter converter = new ImageConverter();
                            //fixed (byte* ptr = (byte[])converter.ConvertTo(ROI, typeof(byte[])))
                            //    roiInfo.data = (IntPtr)(ptr);
                            //proc.CalculateGrayInfo(roiInfo, ref result[i]);//要研究C#和C++怎麼傳結構，先直接傳值好了。        

                            // 不用傳結構的寫法(暫時的，之後要傳結構)
                            double min_temp, max_temp, avg_temp;
                            proc.CalculateGrayInfo_NoStruct((sbyte*)ptr.Scan0.ToPointer(), ROI.Width, ROI.Height, &min_temp, &max_temp, &avg_temp);
                            result[i].min = min_temp; result[i].max = max_temp; result[i].avg = avg_temp;

                            ROI.UnlockBits(ptr);
                        }
                        i++;
                    }

                    showInfo.ShowResultToGrid(this.dataGrid_Data, result, Convert.ToInt16(txtWinNum.Text));
                }
                else
                {
                    MessageBox.Show("The image not single channel, so can't calculate gray mean!");
                }
                
            }
            
        }

        private void btnShowOutline_Click(object sender, EventArgs e)
        {
            if (pctbx_Display.Image == null)
                return;
            else
            {
                formOutline ShowOutlineForm = new formOutline(SrcImg);
                ShowOutlineForm.Show();
            }
                
        }

        #region relate with picture control code
        Point StartPoint;
        private void pctbx_Display_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void pctbx_Display_MouseMove(object sender, MouseEventArgs e)
        {
            Point CurrentPoint = new Point(e.X, e.Y);
            Point RealPosition = new Point(0, 0);
            string DisplayStr;
            pctbxCtrl.CoordinateAfterZoom(ref RealPosition, CurrentPoint);
            DisplayStr = "(x, y) = (" + RealPosition.X.ToString() + ", " + RealPosition.Y.ToString() + ")";
            if (DisplayImg != null && e.X > 0 && e.Y > 0 && RealPosition.X < DisplayImg.Width && RealPosition.Y < DisplayImg.Height)
                DisplayStr = DisplayStr + " || Gray = " + SrcImg.GetPixel(RealPosition.X, RealPosition.Y).ToString();
            else
                DisplayStr = DisplayStr + " || Gray = ";
            label_position.Text = DisplayStr;

            if (e.Button == System.Windows.Forms.MouseButtons.Left && DisplayImg != null && (StartPoint.X != 0 && StartPoint.Y != 0))
            {
                pctbxCtrl.MovePicture(DisplayImg, pctbx_Display, CurrentPoint, StartPoint);
                StartPoint.X = e.X;
                StartPoint.Y = e.Y;
            }
        }

        private void pctbx_Display_MouseWheel(object sender, MouseEventArgs e)
        {
            if (DisplayImg != null)
            {
                Point CurrentMousePos = new Point(e.X, e.Y);

                pctbxCtrl.ZoomPicture(DisplayImg, pctbx_Display, e.Delta, CurrentMousePos);
            }
        }

        #endregion relate with picture control code
    }
}
