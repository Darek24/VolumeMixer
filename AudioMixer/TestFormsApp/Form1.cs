using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormsApp
{
    public partial class Form1 : Form
    {
        readonly List<string> stringArray = new List<string> { "Android Studio", "Skype", "Windows Explorer", "Media Player", "WinAmp", "KMPlayer", "NVIDIA" };
        readonly List<int> intArray = new List<int>{ 150, 20, 13, 19, -100, 40, 30 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            volumeMixerComp2.NamesArray = stringArray;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            volumeMixerComp2.ValuesArray = intArray;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text) - 1;
                string name = textBox2.Text;
                int value = int.Parse(textBox3.Text);

                volumeMixerComp2.ValidateUserEntry(id, name, value);
                volumeMixerComp2.SetTrackBarNameAt(id, name);
                volumeMixerComp2.SetTrackBarValueAt(id, value);

                ColorDialog MyDialog = new ColorDialog();
                MyDialog.AllowFullOpen = false;
                MyDialog.ShowHelp = true;
                MyDialog.Color = textBox1.ForeColor;

                if (MyDialog.ShowDialog() == DialogResult.OK)
                    volumeMixerComp2.SetTrackBarColorAt(id, MyDialog.Color);
            }
            catch (ArgumentException aex){ }
            catch (Exception ex)
            {
                volumeMixerComp2.ValidateUserData();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            volumeMixerComp2.TrackBarNumber = volumeMixerComp2.TrackBarNumber + 1;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            volumeMixerComp2.TrackBarNumber = volumeMixerComp2.TrackBarNumber - 1;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            volumeMixerComp2.TickFrequencyValue = int.Parse(textBox4.Text);
        }
    }
}