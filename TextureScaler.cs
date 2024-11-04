using ImageMagick;

namespace TextureConverter
{
    public partial class TextureScaler : Form
    {
        public TextureScaler()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                textBox2.Text = folderBrowserDialog1.SelectedPath + "\\Output"; // auto-output by default
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog2.SelectedPath;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string inputFolder = textBox1.Text;
            string outputFolder = textBox2.Text;
            string scaleText = comboBox1.Text;
            bool replaceOriginal = checkBox1.Checked;
            bool compression = checkBox2.Checked;
            int scale = int.Parse(scaleText.Replace("%", ""));

            if (!Directory.Exists(inputFolder))
            {
                MessageBox.Show("You need to specify a source directory to get started.", "Failed to find source folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!replaceOriginal)
            {
                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder); // Create output folder if it doesn't exist
            }

            string[] fileSuffixes = { ".TIF", ".PNG", ".JPG", ".JPEG" };
             
            foreach (string file in Directory.GetFiles(inputFolder, "*.*", SearchOption.AllDirectories))
            {
                if (Array.Exists(fileSuffixes, suffix => file.EndsWith(suffix, StringComparison.OrdinalIgnoreCase)))
                {
                    string currentFolder = Path.GetDirectoryName(file) ?? outputFolder;
                    outputFolder = currentFolder + "\\Output";
                    await ProcessTextureScale(file, scale, replaceOriginal, compression, currentFolder, outputFolder);
                }
            }

            MessageBox.Show("All the textures have been scaled, check the destination folder for results.", "Finished scaling textures", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0; // Reset progress bar...
        }

        private async Task ProcessTextureScale(string file, int scale, bool replaceOriginal, bool compression, string inputFolder, string outputFolder)
        {
            progressBar1.Value = 30;
            using (MagickImage textureImage = new MagickImage(file))
            {
                int newWidth = (int)(textureImage.Width * scale / 100);
                int newHeight = (int)(textureImage.Height * scale / 100);
                textureImage.Scale(newWidth, newHeight);
                progressBar1.Value = 60;
                if (compression && file.EndsWith(".TIF", StringComparison.OrdinalIgnoreCase))
                {
                    textureImage.Format = MagickFormat.Tiff;
                    textureImage.Settings.Compression = CompressionMethod.LZW;
                }
                if (replaceOriginal)
                {
                    textureImage.Write(Path.Combine(inputFolder, Path.GetFileName(file)));
                }
                else
                {
                    textureImage.Write(Path.Combine(outputFolder, Path.GetFileName(file)));
                }
                progressBar1.Value = 100;
                textureImage.Dispose();
            }
        }
    }
}