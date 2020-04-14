using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMixer
{
    public partial class TestForm : Form
    {

        int[] numberArray = new int[] { 1000, -100, 50, 34, 43, 20, 60, 90 };
        String[] stringArray = new string[] { "Opera", "Chrome", "Egde", "Eclipse", "NetBeans", "IntelliJ", "Visual Studio" };

        public TestForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            volumeMixerComp1.SetEveryTrackBarName(stringArray);
            volumeMixerComp1.SetEveryTrackBarValue(numberArray);
        }
    }
}
