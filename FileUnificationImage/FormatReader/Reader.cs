using System.Drawing;

namespace FileUnificationImage.FormatReader
{
    internal class Reader
    {
        public static Bitmap Read(string filePath)
        {
            var image = Image.FromFile(filePath);
            return (Bitmap)image;
        }
    }
}
