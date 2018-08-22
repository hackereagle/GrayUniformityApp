using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayUniformityApp
{
    public struct VisionResult
    {
        public double min;
        public double max;
        public double avg;
    }

    public struct ImgParam
    {
        public int Width;
        public int Height;
        //public byte[] data;
        public IntPtr data;
        public int channels;
    }

    class ShowData
    {
        public void ShowResultToGrid(System.Windows.Forms.DataGridView DataGrid, VisionResult[] result, int nomber)
        {
            DataGrid.Rows.Clear();
            for (int i = 0; i < nomber; i++)
            {
                int index = DataGrid.Rows.Add();
                DataGrid.Rows[index].Cells[0].Value = i + 1;
                DataGrid.Rows[index].Cells[1].Value = Math.Round(result[i].avg, 2);
                DataGrid.Rows[index].Cells[2].Value = result[i].min;
                DataGrid.Rows[index].Cells[3].Value = result[i].max;
            }
        }

        private Bitmap HorProfile;
        public void ShowHorProfile(Bitmap SrcImg, double zoom, Point LeftTop, int y, int Pctbx_Width, System.Windows.Forms.PictureBox PctbxProfile)
        {
            HorProfile = new Bitmap(PctbxProfile.Width, PctbxProfile.Height);
            Graphics g = Graphics.FromImage(HorProfile);
            System.Drawing.Pen pen = new Pen(System.Drawing.Color.Blue, 1);

            int x;
            double PreValue, CurrentValue;
            x = Convert.ToInt16((0 - LeftTop.X) / zoom);
            PreValue = x <= 0 ? 0 : (SrcImg.GetPixel(x, y).R + SrcImg.GetPixel(x, y).G + SrcImg.GetPixel(x, y).B) / 3;
            for (int i = 1; i < Pctbx_Width; i++)
            {
                x = Convert.ToInt16((i - LeftTop.X) / zoom);
                if (x <= 0 || x >= SrcImg.Width)
                    CurrentValue = 0;
                else
                    CurrentValue = (SrcImg.GetPixel(x, y).R + SrcImg.GetPixel(x, y).G + SrcImg.GetPixel(x, y).B) / 3;

                g.DrawLine(pen, new Point(i - 1, Convert.ToInt16((1.0 - (double)(PreValue / 255.0)) * PctbxProfile.Height)), new Point(i, Convert.ToInt16((1.0 - (double)(CurrentValue / 255.0)) * PctbxProfile.Height)));
                PreValue = CurrentValue;
            }

            PctbxProfile.Image = HorProfile;
        }

        private Bitmap VerProfile;
        public void ShowVerProfile(Bitmap SrcImg, double zoom, Point LeftTop, int x, int Pctbx_Height, System.Windows.Forms.PictureBox PctbxProfile)
        {
            VerProfile = new Bitmap(PctbxProfile.Width, PctbxProfile.Height);
            Graphics g = Graphics.FromImage(VerProfile);
            System.Drawing.Pen pen = new Pen(System.Drawing.Color.Red, 1);

            int y;
            double PreValue, CurrentValue;
            y = Convert.ToInt16((0 - LeftTop.Y) / zoom);
            PreValue = y <= 0 ? 0 : (SrcImg.GetPixel(x, y).R + SrcImg.GetPixel(x, y).G + SrcImg.GetPixel(x, y).B) / 3;
            for (int i = 1; i < Pctbx_Height; i++)
            {
                y = Convert.ToInt16((i - LeftTop.Y) / zoom);
                if (y <= 0 || y >= SrcImg.Height)
                    CurrentValue = 0;
                else
                    CurrentValue = (SrcImg.GetPixel(x, y).R + SrcImg.GetPixel(x, y).G + SrcImg.GetPixel(x, y).B) / 3;

                g.DrawLine(pen, new Point(Convert.ToInt16((1.0 - (double)(PreValue / 255.0)) * PctbxProfile.Width), i - 1), new Point(Convert.ToInt16((1.0 - (double)(CurrentValue / 255.0)) * PctbxProfile.Width), i));
                PreValue = CurrentValue;
            }

            PctbxProfile.Image = VerProfile;
        }

        public Bitmap GetHorProfileImg()
        {
            return HorProfile;
        }

        public Bitmap GetVerProfileImg()
        {
            return VerProfile;
        }
    }
}
