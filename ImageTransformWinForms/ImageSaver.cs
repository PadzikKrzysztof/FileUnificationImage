using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ImageTransformWinForms
{
    internal class ImageSaver
    {
        public static void Save(Bitmap img, bool isAugmentm, int index)
        {
            if (!isAugmentm)
            {
                img.Save($".\\Output\\{index}.png");
            }
            else
            {
                index *= 10;
                SubSave(img, index++, RotateFlipType.RotateNoneFlipNone);
                SubSave(img, index++, RotateFlipType.RotateNoneFlipY);
                SubSave(img, index++, RotateFlipType.RotateNoneFlipX);
                SubSave(img, index++, RotateFlipType.Rotate90FlipX);
                SubSave(img, index++, RotateFlipType.Rotate270FlipX);
                SubSave(img, index++, RotateFlipType.Rotate180FlipX);
            }
        }

        private static void SubSave(Bitmap img, int index, RotateFlipType rotateFlipType)
        {
            var newImg = new Bitmap(img);
            newImg.RotateFlip(rotateFlipType);
            
            newImg.Save($".\\Output\\{index}.png");
        }
    }
}
