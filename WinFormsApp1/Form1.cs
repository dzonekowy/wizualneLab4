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

        private void grnBtn_Click(object sender, EventArgs e)
        {
            onlyGreen();
        }

        private void onlyGreen()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color greenPixel = Color.FromArgb(0, pixelColor.G, 0);
                    bmp.SetPixel(x, y, greenPixel);
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
