using ImageMagick;
using System;
using System.Threading.Channels;

namespace TextureConverter
{
    public partial class ConvertPBRtoEnfusion : Form
    {
        public ConvertPBRtoEnfusion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

            if (!Directory.Exists(inputFolder))
            {
                MessageBox.Show("You need to specify a source directory to get started.", "Failed to find source folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder); // Create output folder if it doesn't exist

            string[] fileSuffixes = { textBox3.Text + ".PNG", textBox5.Text + ".PNG" };

            // Check the state of the LZW checkbox
            bool useLZWCompression = checkBox1.Checked;

            foreach (string file in Directory.GetFiles(inputFolder))
            {
                if (Array.Exists(fileSuffixes, suffix => file.EndsWith(suffix, StringComparison.OrdinalIgnoreCase)))
                {
                    if (file.EndsWith(textBox3.Text + ".PNG", StringComparison.OrdinalIgnoreCase))
                    {
                        await ProcessBCRTexture(file, useLZWCompression, inputFolder, outputFolder);
                    }
                    else if (file.EndsWith(textBox5.Text + ".PNG", StringComparison.OrdinalIgnoreCase) && !checkBox2.Checked)
                    {
                        await ProcessNMOTexture(file, useLZWCompression, inputFolder, outputFolder);
                    }
                }
            }
            MessageBox.Show("All the texture files within the source folder have been converted, check the destination folder for results.", "Finished converting textures", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0; // Reset progress bar...
        }

        private async Task ProcessBCRTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 25;
            using (MagickImage albedoImage = new MagickImage(file))
            {
                MagickImage roughnessImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox3.Text + ".PNG", textBox4.Text + ".PNG")));
                progressBar1.Value = 50;
                MagickImage roughnessChannel = (MagickImage)roughnessImage.Separate(Channels.Gray).First();
                progressBar1.Value = 75;

                // Composite the new alpha image into the Albedo image
                albedoImage.Alpha(AlphaOption.Transparent);
                albedoImage.Composite(roughnessChannel, CompositeOperator.CopyAlpha);
                progressBar1.Value = 100;
                // Check compression and save image
                if (useLZWCompression)
                {
                    albedoImage.Format = MagickFormat.Tiff;
                    albedoImage.Settings.Compression = CompressionMethod.LZW;
                    albedoImage.Write(Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(file).Replace(textBox3.Text, "_BCR.TIF")));
                }
                else
                {
                    albedoImage.Write(Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(file).Replace(textBox3.Text, "_BCR.TIF")));
                }
                albedoImage.Dispose();
                roughnessImage.Dispose();
                roughnessChannel.Dispose();
            }
        }
        private async Task ProcessNMOTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 20;
            using (MagickImage normalImage = new MagickImage(file))
            {
                MagickImage aoImage = new MagickImage();
                MagickImage aoChannel = new MagickImage();
                MagickImage metalnessImage = new MagickImage();
                MagickImage metalnessChannel = new MagickImage();
                normalImage.Alpha(AlphaOption.Transparent);
                if (!checkBox4.Checked)
                {
                    metalnessImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox5.Text + ".PNG", textBox8.Text + ".PNG")));
                    metalnessChannel = (MagickImage)metalnessImage.Separate(Channels.Gray).First();
                    progressBar1.Value = 40;
                    normalImage.Composite(metalnessChannel, CompositeOperator.CopyBlue);
                }
                progressBar1.Value = 60;
                if (!checkBox3.Checked)
                {
                    aoImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox5.Text + ".PNG", textBox7.Text + ".PNG")));
                    aoChannel = (MagickImage)aoImage.Separate(Channels.Gray).First();
                    progressBar1.Value = 80;
                    normalImage.Composite(aoChannel, CompositeOperator.CopyAlpha);
                }
                progressBar1.Value = 100;
                if (useLZWCompression)
                {
                    normalImage.Format = MagickFormat.Tiff;
                    normalImage.Settings.Compression = CompressionMethod.LZW;
                    normalImage.Write(Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(file).Replace(textBox5.Text, "_NMO.TIF")));
                }
                else
                {
                    normalImage.Write(Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(file).Replace(textBox5.Text, "_NMO.TIF")));
                }
                normalImage.Dispose();
                metalnessChannel.Dispose();
                aoChannel.Dispose();
                metalnessImage.Dispose();
                aoImage.Dispose();
            }
        }
    }
}