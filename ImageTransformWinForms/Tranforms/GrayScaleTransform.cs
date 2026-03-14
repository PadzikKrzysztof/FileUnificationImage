using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUnificationImage.Tranforms
{
    internal class GrayScaleTransform
    {
        public static Bitmap Transform(Bitmap img)
        {
            var newImg = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j);
                    var gray = 0.2126*pixel.R + 0.7152*pixel.G +  0.0722*pixel.B;
                    newImg.SetPixel(i, j, Color.FromArgb((int)gray, (int)gray, (int)gray));
                }
            }

            return newImg;
        }
    }
}
