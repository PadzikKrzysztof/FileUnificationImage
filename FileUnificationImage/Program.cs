using FileUnificationImage.FormatReader;
using FileUnificationImage.Tranforms;
using System.Drawing;

var files = Directory.GetFiles(".\\Input");
int index = 0;
foreach (var file in files)
{
    var img = Reader.Read(file);
    var newImg = SizeTransform.Transform(img, 256, 256);
    newImg = ContrastTransform.Transform(newImg, 128);
    newImg = GrayScaleTransform.Transform(newImg);
    newImg = EdgeTransform.Transform(newImg, 50);
    newImg.Save($".\\Output\\{index}.tiff");
    Console.WriteLine($".\\Output\\{index}.tiff");
    index++;
}

Console.WriteLine("Koniec");
Console.ReadLine();
