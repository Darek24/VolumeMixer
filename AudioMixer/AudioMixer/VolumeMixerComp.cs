using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMixer
{
    public partial class VolumeMixerComp : UserControl
    {
        List<TextBox> nameList;
        List<TextBox> numberList;
        List<TrackBar> trackBarList;
        List<TableLayoutPanel> panelList;


        List<string> namesArray = new List<string> { };
        List<int> valuesArray = new List<int>();

        int trackBarNumber, tickFrequencyValue;
        Color backgroundColor, trackBarColor, trackBarNameColor, trackBarValueColor;

        [Category("Component Settings"), Description("Number of trackbars")]
        public int TrackBarNumber
        {
            get
            {
                return trackBarNumber;
            }
            set
            {
                trackBarNumber = value;
                CheckValuesArray();
                CheckNamesArray();
                CreateTrackBars();
                SetEveryTrackBarValue();
                SetEveryTrackBarName();
                Invalidate();
            }
        }


        [Category("Component Settings"), Description("Background Color")]
        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }
            set
            {
                backgroundColor = value;
                SetBackgroundColor();
                Invalidate();
            }
        }

        [Category("Component Settings"), Description("Trackbar Color")]
        public Color TrackBarColor
        {
            get
            {
                return trackBarColor;
            }
            set
            {
                trackBarColor = value;
                SetEveryTrackBarColor();
                Invalidate();
            }
        }

        [Category("Component Settings"), Description("Color of trackbar name")]
        public Color TrackBarNameColor
        {
            get
            {
                return trackBarNameColor;
            }
            set
            {
                trackBarNameColor = value;
                SetEveryNameColor();
                Invalidate();
            }
        }

        [Category("Component Settings"), Description("Color of trackbar value")]
        public Color TrackBarValueColor
        {
            get
            {
                return trackBarValueColor;
            }
            set
            {
                trackBarValueColor = value;
                SetEveryValueColor();
                Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Culture = neutral, PublicKeyToken=b03f5f7f11d50a3a",
            typeof(System.Drawing.Design.UITypeEditor))]

        [Category("Component Settings"), Description("Names of trackbars")]
        public List<string> NamesArray
        {
            get
            {
                SetEveryTrackBarName();
                Invalidate();
                return namesArray;

            }
            set
            {
                namesArray = value;
                SetEveryTrackBarName();
                Invalidate();
            }
        }


        [Category("Component Settings"), Description("Values of trackbars")]
        public List<int> ValuesArray
        {
            get
            {
                ChangeValuesOfValueArray();
                SetEveryTrackBarValue();
                Invalidate();
                return valuesArray;
            }
            set
            {
                valuesArray = value;
                ChangeValuesOfValueArray();
                SetEveryTrackBarValue();
                Invalidate();
            }
        }

        [Category("Component Settings"), Description("Value of trackbars' tick frequency")]
        public int TickFrequencyValue
        {
            get
            {
                return tickFrequencyValue;
            }
            set
            {
                tickFrequencyValue = value;
                SetTickFrequencyValue();
                Invalidate();
            }
        }


        public VolumeMixerComp()
        {
            InitializeComponent();

            InitializeLists();

        }

        private void InitializeLists()
        {
            nameList = new List<TextBox>();
            numberList = new List<TextBox>();
            trackBarList = new List<TrackBar>();
            panelList = new List<TableLayoutPanel>();
        }

        private void RemoveTrackBars()
        {
            for (int i = nameList.Count - 1; i >= 0; i--)
            {
                mainPanel.Controls.Remove(panelList[i]);

                panelList[i].Controls.Remove(nameList[i]);
                panelList[i].Controls.Remove(numberList[i]);
                panelList[i].Controls.Remove(trackBarList[i]);

                trackBarList[i].Scroll -= new EventHandler(TrackBar_Scroll);

                nameList[i].Dispose();
                numberList[i].Dispose();
                trackBarList[i].Dispose();
                panelList[i].Dispose();

                nameList.RemoveAt(i);
                numberList.RemoveAt(i);
                trackBarList.RemoveAt(i);
                panelList.RemoveAt(i);
            }
            for (int i = mainPanel.ColumnStyles.Count - 1; i >= 0; i--)
            {
                mainPanel.ColumnStyles.RemoveAt(i);
            }


        }

        private void CreateTrackBars()
        {
            RemoveTrackBars();

            for (int i = 0; i < trackBarNumber; i++)
            {
                panelList.Add(new TableLayoutPanel());

                nameList.Add(new TextBox());

                numberList.Add(new TextBox());

                trackBarList.Add(new TrackBar());
            }
            mainPanel.ColumnCount = trackBarNumber;
            for (int i = 0; i < trackBarNumber; i++)
            {
                mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / trackBarNumber));
            }
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0F));

            for (int i = 0; i < trackBarNumber; i++)
            {

                nameList[i].Dock = DockStyle.Fill;
                nameList[i].Location = new Point(3, 3);
                nameList[i].Name = "nameTextBox" + i;
                nameList[i].ReadOnly = true;
                nameList[i].Size = new Size(140, 20);
                nameList[i].TabIndex = 4;
                nameList[i].Text = "Google Chrome " + (i + 1);
                nameList[i].TextAlign = HorizontalAlignment.Center;
                nameList[i].BackColor = trackBarNameColor;

                numberList[i].Dock = DockStyle.Fill;
                numberList[i].Location = new Point(3, 315);
                numberList[i].Name = "numberTextBox" + i;
                numberList[i].ReadOnly = true;
                numberList[i].Size = new Size(140, 20);
                numberList[i].TabIndex = 5;
                numberList[i].Text = "0";
                numberList[i].TextAlign = HorizontalAlignment.Center;
                numberList[i].BackColor = trackBarValueColor;

                trackBarList[i].Dock = DockStyle.Fill;
                trackBarList[i].LargeChange = 10;
                trackBarList[i].Location = new Point(3, 37);
                trackBarList[i].Maximum = 100;
                trackBarList[i].Name = "trackBar" + i;
                trackBarList[i].Orientation = Orientation.Vertical;
                trackBarList[i].Size = new Size(140, 272);
                trackBarList[i].SmallChange = 5;
                trackBarList[i].TabIndex = 1;
                trackBarList[i].TickFrequency = 10;
                trackBarList[i].Scroll += new EventHandler(TrackBar_Scroll);
                trackBarList[i].BackColor = trackBarColor;

                panelList[i].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                panelList[i].ColumnCount = 1;
                panelList[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                panelList[i].Controls.Add(numberList[i], 0, 2);
                panelList[i].Controls.Add(nameList[i], 0, 0);
                panelList[i].Controls.Add(trackBarList[i], 0, 1);
                panelList[i].Location = new Point(3, 3);
                panelList[i].Name = "Panel" + i;
                panelList[i].RowCount = 3;
                panelList[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                panelList[i].RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
                panelList[i].RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                panelList[i].Size = new Size(146, 348);
                panelList[i].TabIndex = 2;

                mainPanel.Controls.Add(panelList[i], i, 0);

            }
        }


        public void SetTrackBarValueAt(int i, int value)
        {
            try
            {
                trackBarList[i].Value = CheckValue(value);
                numberList[i].Text = CheckValue(value).ToString();
                Invalidate();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SetTrackBarNameAt(int i, string name)
        {
            try
            {
                nameList[i].Text = name;
                Invalidate();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SetTrackBarColorAt(int i, Color color)
        {
            try
            {
                trackBarList[i].BackColor = color;
                Invalidate();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void SetEveryTrackBarValue()
        {
            try
            {
                List<int> tab = valuesArray;
                int n = tab.Count();
                if (tab.Count() >= trackBarNumber)
                {
                    n = trackBarNumber;
                }
                for (int i = 0; i < n; i++)
                {
                    SetTrackBarValueAt(i, tab.ElementAt(i));
                }

                Invalidate();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SetEveryTrackBarName()
        {
            try
            {
                List<string> tab = namesArray;
                int n = tab.Count();
                if (tab.Count() >= trackBarNumber)
                {
                    n = trackBarNumber;
                }
                for (int i = 0; i < n; i++)
                {
                    SetTrackBarNameAt(i, tab.ElementAt(i));
                }

                Invalidate();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void CheckValuesArray()
        {
            try
            {
                if (trackBarNumber > valuesArray.Count())
                {
                    for (int i = trackBarNumber - valuesArray.Count(); i > 0; i--)
                    {
                        valuesArray.Add(50);
                    }
                }
                else if (trackBarNumber < valuesArray.Count())
                {
                    for (int i = valuesArray.Count() - 1; i >= trackBarNumber; i--)
                    {

                        valuesArray.RemoveAt(i);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void CheckNamesArray()
        {
            try {
                if (trackBarNumber > namesArray.Count())
                {
                    for (int i = trackBarNumber - namesArray.Count(); i > 0; i--)
                    {
                        string textArray = "Google Chrome " + (trackBarNumber - i + 1);
                        namesArray.Add(textArray);
                    }
                }
                else if (trackBarNumber < namesArray.Count())
                {
                    for (int i = namesArray.Count() - 1; i >= trackBarNumber; i--)
                    {
                        namesArray.RemoveAt(i);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void ChangeValuesOfValueArray()
        {
            try
            {
                for (int j = 0; j < valuesArray.Count(); j++)
                {
                    if (valuesArray.ElementAt(j) > 100 || valuesArray.ElementAt(j) < 0)
                    {
                        int number = CheckValue(valuesArray.ElementAt(j));
                        valuesArray.RemoveAt(j);
                        valuesArray.Insert(j, number);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private int CheckValue(int v)
        {
            if (v < 0)
            {
                return 0;
            }
            else if (v > 100)
            {
                return 100;
            }
            else
            {
                return v;
            }
        }
        private void SetEveryNameColor()
        {
            try
            {
                for (int i = 0; i < trackBarNumber; i++)
                {
                    nameList[i].BackColor = trackBarNameColor;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SetEveryValueColor()
        {
            try
            {
                for (int i = 0; i < trackBarNumber; i++)
                {
                    numberList[i].BackColor = trackBarValueColor;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void SetEveryTrackBarColor()
        {
            try
            {
                for (int i = 0; i < trackBarNumber; i++)
                {
                    trackBarList[i].BackColor = trackBarColor;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void SetBackgroundColor()
        {
            try
            {
                mainPanel.BackColor = BackgroundColor;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private void SetTickFrequencyValue()
        {
            try
            {
                for (int i = 0; i < trackBarNumber; i++)
                {
                    trackBarList[i].TickFrequency = tickFrequencyValue;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {

            TrackBar tkbar = sender as TrackBar;

            int i = int.Parse(tkbar.Name.Substring(8));

            numberList[i].Text = tkbar.Value.ToString();

        }
        public void ValidateUserEntry(int id, string name, int value)
        {
            string message = null;
            if (!(id <= namesArray.Count && id >= 0))
            {
                message = "Wprowadzono błędny index\n";
            }
            if (name.Length > 20)
            {
                message += "Zadługa nazwa słupka\n";
            }
            if (!(value >= 0 && (value <= 100)))
            {
                message += "Nie prawidłowa wartość";
            }

            if (message != null) {

                string caption = "Wprowadzono błędne dane";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    throw new System.ArgumentException();

                }
            }
        }

        public void ValidateUserData()
        {
            string message = "Błędny format danych";
            string caption = "Wprowadzono błędne dane";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
            }
        }
    }
}