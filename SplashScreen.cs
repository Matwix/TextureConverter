using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TextureConverter
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread convertUnrealtoEnfusionThread = new Thread(LaunchConvertUnrealtoEnfusion);
            convertUnrealtoEnfusionThread.SetApartmentState(ApartmentState.STA); // Set the thread to single-threaded apartment state for UI compatibility
            convertUnrealtoEnfusionThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread convertPBRtoEnfusionThread = new Thread(LaunchConvertPBRtoEnfusion);
            convertPBRtoEnfusionThread.SetApartmentState(ApartmentState.STA); // Set the thread to single-threaded apartment state for UI compatibility
            convertPBRtoEnfusionThread.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread textureScalerThread = new Thread(LaunchTextureScaler);
            textureScalerThread.SetApartmentState(ApartmentState.STA); // Set the thread to single-threaded apartment state for UI compatibility
            textureScalerThread.Start();
        }

        private void LaunchConvertUnrealtoEnfusion()
        {
            ConvertUnrealtoEnfusion convertUnrealtoEnfusion = new ConvertUnrealtoEnfusion();
            Application.Run(convertUnrealtoEnfusion);
        }
        private void LaunchConvertPBRtoEnfusion()
        {
            ConvertPBRtoEnfusion convertPBRtoEnfusion = new ConvertPBRtoEnfusion();
            Application.Run(convertPBRtoEnfusion);
        }
        private void LaunchTextureScaler()
        {
            TextureScaler textureScaler = new TextureScaler();
            Application.Run(textureScaler);
        }
    }
}
