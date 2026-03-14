using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUnificationImage.Tranforms
{
    internal class SizeTransform
    {
        public static Bitmap Transform(Bitmap img, int width, int height)
        { 
            var newImg = new Bitmap(width, height);
            var hieghtScale = (double)img.Height / (double)height;
            var widthScale = (double)img.Width / (double)width;

            for (int i = 0; i < newImg.Width; i++)
            {
                for (int j = 0; j < newImg.Height; j++)
                {
                    var pixel = img.GetPixel((int)Math.Floor(i * widthScale), (int)Math.Floor(j * hieghtScale));
                    newImg.SetPixel(i, j, pixel);
                }
            }

            return newImg;
        }
    }
}
