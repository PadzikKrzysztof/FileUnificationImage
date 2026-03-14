using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUnificationImage.Tranforms
{
    internal class EdgeTransform
    {
        public static Bitmap Transform(Bitmap img, int threashold)
        {
            var newImg = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (i == 0 || j == 0 || i == img.Width - 1 || j == img.Height - 1)
                    {
                        newImg.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));

                        continue;
                    }

                    var grayVale = (int)img.GetPixel(i - 1, j - 1).R;
                    grayVale += (int)img.GetPixel(i - 1, j).R;
                    grayVale += (int)img.GetPixel(i - 1, j + 1).R;
                    grayVale += (int)img.GetPixel(i, j - 1).R;
                    grayVale += (int)img.GetPixel(i, j).R * (-8);
                    grayVale += (int)img.GetPixel(i, j + 1).R;
                    grayVale += (int)img.GetPixel(i+1, j - 1).R;
                    grayVale += (int)img.GetPixel(i + 1, j).R;
                    grayVale += (int)img.GetPixel(i + 1, j + 1).R;

                    grayVale = Math.Abs(grayVale);
                    if (grayVale <= threashold)
                    {
                        newImg.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        newImg.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            return newImg;
        }
    }
}
