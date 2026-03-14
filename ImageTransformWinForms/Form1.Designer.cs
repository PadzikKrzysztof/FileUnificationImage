namespace ImageTransformWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            trackBarContrast = new TrackBar();
            label1 = new Label();
            checkBoxContrast = new CheckBox();
            groupBox2 = new GroupBox();
            checkBoxGrayScale = new CheckBox();
            groupBox3 = new GroupBox();
            trackBarEdge = new TrackBar();
            label2 = new Label();
            checkBoxEdge = new CheckBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            textBoxSizeY = new TextBox();
            label3 = new Label();
            textBoxSzieX = new TextBox();
            checkBoxScale = new CheckBox();
            buttonFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarEdge).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(344, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(358, 255);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 273);
            button1.Name = "button1";
            button1.Size = new Size(326, 29);
            button1.TabIndex = 9;
            button1.Text = "Wczytaj Obraz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 308);
            button2.Name = "button2";
            button2.Size = new Size(326, 29);
            button2.TabIndex = 10;
            button2.Text = "Przetwórz obraz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trackBarContrast);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBoxContrast);
            groupBox1.Location = new Point(708, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 99);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kontrast";
            // 
            // trackBarContrast
            // 
            trackBarContrast.Location = new Point(93, 43);
            trackBarContrast.Maximum = 255;
            trackBarContrast.Minimum = -255;
            trackBarContrast.Name = "trackBarContrast";
            trackBarContrast.Size = new Size(226, 56);
            trackBarContrast.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Wartosc";
            // 
            // checkBoxContrast
            // 
            checkBoxContrast.AutoSize = true;
            checkBoxContrast.Location = new Point(12, 25);
            checkBoxContrast.Name = "checkBoxContrast";
            checkBoxContrast.Size = new Size(97, 24);
            checkBoxContrast.TabIndex = 0;
            checkBoxContrast.Text = "załączone";
            checkBoxContrast.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxGrayScale);
            groupBox2.Location = new Point(708, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 60);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Skala szarosci";
            // 
            // checkBoxGrayScale
            // 
            checkBoxGrayScale.AutoSize = true;
            checkBoxGrayScale.Location = new Point(12, 25);
            checkBoxGrayScale.Name = "checkBoxGrayScale";
            checkBoxGrayScale.Size = new Size(97, 24);
            checkBoxGrayScale.TabIndex = 0;
            checkBoxGrayScale.Text = "załączone";
            checkBoxGrayScale.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trackBarEdge);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(checkBoxEdge);
            groupBox3.Location = new Point(708, 183);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(325, 99);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wykrycie krawędzi";
            // 
            // trackBarEdge
            // 
            trackBarEdge.Location = new Point(93, 43);
            trackBarEdge.Maximum = 255;
            trackBarEdge.Minimum = -255;
            trackBarEdge.Name = "trackBarEdge";
            trackBarEdge.Size = new Size(226, 56);
            trackBarEdge.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Wartosc";
            // 
            // checkBoxEdge
            // 
            checkBoxEdge.AutoSize = true;
            checkBoxEdge.Location = new Point(12, 25);
            checkBoxEdge.Name = "checkBoxEdge";
            checkBoxEdge.Size = new Size(97, 24);
            checkBoxEdge.TabIndex = 0;
            checkBoxEdge.Text = "załączone";
            checkBoxEdge.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(textBoxSizeY);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(textBoxSzieX);
            groupBox4.Controls.Add(checkBoxScale);
            groupBox4.Location = new Point(708, 288);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(325, 136);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rozmiar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 4;
            label4.Text = "Wartosc Y";
            // 
            // textBoxSizeY
            // 
            textBoxSizeY.Location = new Point(93, 86);
            textBoxSizeY.Name = "textBoxSizeY";
            textBoxSizeY.Size = new Size(226, 27);
            textBoxSizeY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Wartosc X";
            // 
            // textBoxSzieX
            // 
            textBoxSzieX.Location = new Point(93, 55);
            textBoxSzieX.Name = "textBoxSzieX";
            textBoxSzieX.Size = new Size(226, 27);
            textBoxSzieX.TabIndex = 1;
            // 
            // checkBoxScale
            // 
            checkBoxScale.AutoSize = true;
            checkBoxScale.Location = new Point(12, 25);
            checkBoxScale.Name = "checkBoxScale";
            checkBoxScale.Size = new Size(97, 24);
            checkBoxScale.TabIndex = 0;
            checkBoxScale.Text = "załączone";
            checkBoxScale.UseVisualStyleBackColor = true;
            // 
            // buttonFolder
            // 
            buttonFolder.Location = new Point(12, 346);
            buttonFolder.Name = "buttonFolder";
            buttonFolder.Size = new Size(326, 29);
            buttonFolder.TabIndex = 15;
            buttonFolder.Text = "Przetwórz Folder Input";
            buttonFolder.UseVisualStyleBackColor = true;
            buttonFolder.Click += buttonFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 450);
            Controls.Add(buttonFolder);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarEdge).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox checkBoxContrast;
        private GroupBox groupBox2;
        private CheckBox checkBoxGrayScale;
        private GroupBox groupBox3;
        private Label label2;
        private CheckBox checkBoxEdge;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox textBoxSizeY;
        private Label label3;
        private TextBox textBoxSzieX;
        private CheckBox checkBoxScale;
        private TrackBar trackBarContrast;
        private TrackBar trackBarEdge;
        private Button buttonFolder;
    }
}
