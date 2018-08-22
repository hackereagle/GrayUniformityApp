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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string ImagePath;
        Bitmap ScrImg;
        Image DisplayImg;
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
                ScrImg = new Bitmap(openImgDialog.FileName);
                DisplayImg = new Bitmap(openImgDialog.FileName);
                pctbx_Display.Image = DisplayImg;
            }
        }

        Bitmap[] RoiImage;
        private void btn_DrawWin_Click(object sender, EventArgs e)
        {
            int WinNum, WinSize, WinsInterval, x, y;
            WinNum = Convert.ToInt16(txtWinNum.Text);
            WinSize = Convert.ToInt16(txtWinSize.Text);
            WinsInterval = Convert.ToInt16(txtWinsInterval.Text);
            x = Convert.ToInt16(txt1WinX.Text);
            y = Convert.ToInt16(txt1WinY.Text);

            if ((x + WinsInterval * 2 + 3 * WinSize) < ScrImg.Width &&
                (y + WinsInterval * 2 + 3 * WinSize) < ScrImg.Height)
            {
                int k = 0;
                RoiImage = new Bitmap[WinNum];
                for(int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        RoiImage[k] = ScrImg.Clone(new System.Drawing.Rectangle(
                            x + k * WinSize + (k - 1) * WinsInterval, y + k * WinSize + (k - 1) * WinsInterval, WinSize, WinSize),
                            ScrImg.PixelFormat);

                        Graphics g = System.Drawing.Graphics.FromImage(DisplayImg);

                        k++;
                    }
                    
            }
            else
            {
                MessageBox.Show("That will has recipe out of figure!", "Warning!");
            }
            
        }

        private void btnConduct_Click(object sender, EventArgs e)
        {
            //double avg, min, max;
            foreach (Bitmap ROI in RoiImage)
            {

            }
        }

        private void btnShowOutline_Click(object sender, EventArgs e)
        {
            formOutline ShowOutlineForm = new formOutline(ScrImg);
            ShowOutlineForm.Show();
        }

        

        #region relate with picture control code
        PctbxControl pctbxCtrl = new PctbxControl();
        Point startPoint;

        private void pctbx_Display_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
        }

        private void pctbx_Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int delta_x = e.X - startPoint.X;
                int delta_y = e.Y - startPoint.Y;

                pctbxCtrl.MovePicture(DisplayImg, pctbx_Display, delta_x, delta_y);
            }
        }

        private void pctbx_Display_MouseWheel(object sender, MouseEventArgs e)
        {
            pctbxCtrl.ZoomPicture(DisplayImg, pctbx_Display, e.Delta);
        }


        #endregion relate with picture control code

        private void tableLayoutPanel_Pctbx_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
