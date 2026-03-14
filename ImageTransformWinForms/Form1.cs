using FileUnificationImage.Tranforms;
using System.ComponentModel;

namespace ImageTransformWinForms
{
    public partial class Form1 : Form
    {
        private Bitmap _oryginal;
        private Bitmap _preprocessed;
        private Bitmap _transformed;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Bitmap Oryginal
        {
            get => _oryginal;
            set
            {
                _oryginal = value;
                _preprocessed = value;
                pictureBox1.Image = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Bitmap Preprocessed { get => _preprocessed; set => _preprocessed = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Bitmap Transformed
        {
            get => _transformed; set
            {
                _transformed = value;
                pictureBox2.Image = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            Oryginal = (Bitmap)Image.FromFile(dlg.FileName);
        }

        private void Transform()
        {
            Preprocessed = Oryginal;
            if (checkBoxScale.Checked)
            {
                Preprocessed = SizeTransform.Transform(Preprocessed, int.Parse(textBoxSzieX.Text), int.Parse(textBoxSizeY.Text));
            }
            if (checkBoxContrast.Checked)
            {
                Preprocessed = ContrastTransform.Transform(Preprocessed, trackBarContrast.Value);
            }
            if (checkBoxGrayScale.Checked)
            {
                Preprocessed = GrayScaleTransform.Transform(Preprocessed);
            }
            if (checkBoxEdge.Checked)
            {
                Preprocessed = EdgeTransform.Transform(Preprocessed, trackBarEdge.Value);
            }
            Transformed = Preprocessed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transform();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(".\\Input");
            int index = 0;
            foreach (var file in files)
            {
                var img = (Bitmap)Image.FromFile(file);
                var newImg = SizeTransform.Transform(img, int.Parse(textBoxSzieX.Text), int.Parse(textBoxSizeY.Text));
                newImg = ContrastTransform.Transform(newImg, trackBarContrast.Value);
                newImg = GrayScaleTransform.Transform(newImg);
                newImg = EdgeTransform.Transform(newImg, trackBarEdge.Value);
                newImg.Save($".\\Output\\{index}.tiff");
                Console.WriteLine($".\\Output\\{index}.tiff");
                index++;
            }
        }
    }
}
