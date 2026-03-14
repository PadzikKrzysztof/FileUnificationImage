using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTransformWinForms.Tranforms
{
    internal class AddTransform
    {
        public static Bitmap Transform(Bitmap imgA, Bitmap imgB)
        {
            var newImg = new Bitmap(imgA.Width, imgA.Height);
            for (int i = 0; i < imgA.Width; i++)
            {
                for (int j = 0; j < imgA.Height; j++)
                {
                    var pixelA = imgA.GetPixel(i, j);
                    var pixelB = imgB.GetPixel(i, j);
                    newImg.SetPixel(i, j, Add(pixelA, pixelB));
                }
            }

            return newImg;
        }

        private static Color Add(Color a, Color b)
        {
            var r = a.R + b.R;
            var g = a.G + b.G;
            var _b = a.B + b.B;

            return Color.FromArgb(r/2, g/2, _b / 2);
        }
    }
}
