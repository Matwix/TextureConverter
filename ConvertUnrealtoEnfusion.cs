using ImageMagick;
using System;

namespace TextureConverter
{
    public partial class ConvertUnrealtoEnfusion : Form
    {
        public ConvertUnrealtoEnfusion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                textBox2.Text = folderBrowserDialog1.SelectedPath; // auto-output by default
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

            string[] fileSuffixes = { textBox3.Text + ".PNG", textBox6.Text + ".PNG", textBox5.Text + ".PNG" };

            // Check the state of the LZW checkbox
            bool useLZWCompression = checkBox1.Checked;

            List<string> completeTextures = new List<string>();

            foreach (string folder in Directory.GetDirectories(inputFolder))
            {
                foreach (string file in Directory.GetFiles(folder))
                {
                    if (Array.Exists(fileSuffixes, suffix => file.EndsWith(suffix, StringComparison.OrdinalIgnoreCase)))
                    {
                        if (comboBox1.SelectedItem.ToString() == "MR/MetalnessRoughness")
                        {
                            if (file.EndsWith(textBox3.Text + ".PNG", StringComparison.OrdinalIgnoreCase))
                            {
                                await MR_ProcessBCRTexture(file, useLZWCompression, folder, folder);
                            }
                            else if (file.EndsWith(textBox5.Text + ".PNG", StringComparison.OrdinalIgnoreCase))
                            {
                                await MR_ProcessNMOTexture(file, useLZWCompression, folder, folder);
                            }
                        }
                        else if (comboBox1.SelectedItem.ToString() == "AORM/ARM")
                        {
                            if (file.EndsWith(textBox3.Text + ".PNG", StringComparison.OrdinalIgnoreCase))
                            {
                                await AORM_ProcessBCRTexture(file, useLZWCompression, folder, folder);
                            }
                            else if (file.EndsWith(textBox5.Text + ".PNG", StringComparison.OrdinalIgnoreCase))
                            {
                                await AORM_ProcessNMOTexture(file, useLZWCompression, folder, folder);
                            }
                        }
                        completeTextures.Add(file);
                    }
                }
            }
            MessageBox.Show("All the texture files within the source folder have been converted, check the destination folder for results.", "Finished converting textures", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0; // Reset progress bar...
            foreach(var file in completeTextures)
            {
                File.Delete(file);
            }
        }

        private async Task AORM_ProcessBCRTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 25;
            using (MagickImage albedoImage = new MagickImage(file))
            {
                MagickImage masksImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox3.Text + ".PNG", textBox6.Text + ".PNG")));
                progressBar1.Value = 50;
                MagickImage masksGreenChannel = (MagickImage)masksImage.Separate(Channels.Green).First();
                progressBar1.Value = 75;

                // Composite the new alpha image into the Albedo image
                albedoImage.Alpha(AlphaOption.Transparent);
                albedoImage.Composite(masksGreenChannel, CompositeOperator.CopyAlpha);
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
                masksImage.Dispose();
                masksGreenChannel.Dispose();
            }
        }
        private async Task MR_ProcessBCRTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 25;
            using (MagickImage albedoImage = new MagickImage(file))
            {
                MagickImage masksImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox3.Text + ".PNG", textBox6.Text + ".PNG")));
                masksImage.Negate(); // Invert
                progressBar1.Value = 50;
                MagickImage masksGreenChannel = (MagickImage)masksImage.Separate(Channels.Green).First();
                progressBar1.Value = 75;

                // Composite the new alpha image into the Albedo image
                albedoImage.Alpha(AlphaOption.Transparent);
                albedoImage.Composite(masksGreenChannel, CompositeOperator.CopyAlpha);
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
                masksImage.Dispose();
                masksGreenChannel.Dispose();
            }
        }
        private async Task AORM_ProcessNMOTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 20;
            using (MagickImage normalImage = new MagickImage(file))
            {
                MagickImage masksImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox5.Text + ".PNG", textBox6.Text + ".PNG")));
                progressBar1.Value = 40;
                MagickImage masksRedChannel = (MagickImage)masksImage.Separate(Channels.Red).First();
                progressBar1.Value = 60;
                MagickImage masksBlueChannel = (MagickImage)masksImage.Separate(Channels.Blue).First();
                progressBar1.Value = 80;
                // Composite the new alpha image into the Normal image
                normalImage.Alpha(AlphaOption.Transparent);
                normalImage.Composite(masksBlueChannel, CompositeOperator.CopyBlue);
                normalImage.Composite(masksRedChannel, CompositeOperator.CopyAlpha);
                progressBar1.Value = 100;
                // Check compression and save image
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
                masksImage.Dispose();
                masksRedChannel.Dispose();
                masksBlueChannel.Dispose();
            }
        }

        private async Task MR_ProcessNMOTexture(string file, bool useLZWCompression, string inputFolder, string outputFolder)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            progressBar1.Value = 20;
            using (MagickImage normalImage = new MagickImage(file))
            {
                MagickImage masksImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox5.Text + ".PNG", textBox6.Text + ".PNG")));
                progressBar1.Value = 50;
                MagickImage masksBlueChannel = (MagickImage)masksImage.Separate(Channels.Blue).First();
                MagickImage occlusionImage = new MagickImage(Path.Combine(inputFolder, file.Replace(textBox5.Text + ".PNG", "_Occlusion.PNG")));
                progressBar1.Value = 60;
                MagickImage masksRedChannel = (MagickImage)occlusionImage.Separate(Channels.Red).First();
                progressBar1.Value = 75;
                // Composite the new alpha image into the Normal image
                normalImage.Alpha(AlphaOption.Transparent);
                normalImage.Composite(masksBlueChannel, CompositeOperator.CopyBlue);
                normalImage.Composite(masksRedChannel, CompositeOperator.CopyAlpha);
                progressBar1.Value = 100;
                // Check compression and save image
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
                masksImage.Dispose();
                masksBlueChannel.Dispose();
                masksRedChannel.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "MR/MetalnessRoughness")
            {
                textBox3.Text = "_BaseColor";
                groupBox7.Text = "MetallicRoughness";
                textBox6.Text = "_MetallicRoughness";
            }
            else if (comboBox1.SelectedItem.ToString() == "AORM/ARM")
            {
                textBox3.Text = "_Albedo";
                groupBox7.Text = "Masks";
                textBox6.Text = "_Masks";
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}