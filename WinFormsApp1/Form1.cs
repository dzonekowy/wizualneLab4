using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imgLoad_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void loadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    Image img = Image.FromFile(filePath);
                    pictureBox1.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void rotateBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            else if (radioButton1.Checked)
            {
                rotateImage90();
            }
            else if (radioButton2.Checked)
            {
                rotateImage180();
            }
            else if (radioButton3.Checked)
            {
                rotateImage270();
            }
        }

        private void rotateImage90()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void rotateImage180()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void rotateImage270()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            InvertColours("Invert", null);
        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            InvertColours("Upside", null);
        }

        private void InvertColours(string mode, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            
            if(mode == "Invert")
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                        bmp.SetPixel(x, y, invertedColor);
                    }
                }
                pictureBox1.Image = bmp;
            }
            else if(mode == "Upside")
            {   
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixelColor = bmp.GetPixel(x, y);
                        Color upsideDownColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                        bmp.SetPixel(x, bmp.Height - 1 - y, upsideDownColor);
                    }
                }
            }
        }
    }
}
