using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUnificationImage.Tranforms
{
    internal class ContrastTransform
    {
        public static Bitmap Transform(Bitmap img, double contrastValue)
        {
            double factor = (259 * (contrastValue + 255)) / (255 * (259 - contrastValue));
            var newImg = new Bitmap(img.Width, img.Height);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    var pixel = img.GetPixel(i, j).R;
                    newImg.SetPixel(i, j,
                        Color.FromArgb( CalculateNewValue(img.GetPixel(i, j).R, factor),
                        CalculateNewValue(img.GetPixel(i, j).G, factor),
                        CalculateNewValue(img.GetPixel(i, j).B, factor)));
                }
            }

            return newImg;
        }

        public static int CalculateNewValue(int col, double factor)
        {
            var newValue = factor * (col - 128) + 128;
            if (newValue > 255)
            {
                newValue = 255;
            }
            if (newValue < 0)
            {
                newValue = 0;
            }

            return (int)newValue;
        }
    }
}
