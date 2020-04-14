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

        int trackBarNumber;
        Color backgroundColor;

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
                CreateTrackBars(value);
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
                ChangeBackgroundColor();
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

        public void RemoveTrackBars()
        {
            for (int i = nameList.Count - 1; i >= 0; i--)
            {
                MainPanel.Controls.Remove(panelList[i]);
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
        }

        public void CreateTrackBars(int n)
        {
            RemoveTrackBars();

            trackBarNumber = n;
            for (int i = 0; i < trackBarNumber; i++)
            {
                panelList.Add(new TableLayoutPanel());

                nameList.Add(new TextBox());

                numberList.Add(new TextBox());

                trackBarList.Add(new TrackBar());
            }


            for (int i = 0; i < trackBarNumber; i++)
            {
                MainPanel.Controls.Add(panelList[i]);

                panelList[i].Name = "LayoutPanel" + i;
                panelList[i].AutoSize = true;
                panelList[i].AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panelList[i].ColumnCount = 1;
                panelList[i].ColumnStyles.Add(new ColumnStyle());
                panelList[i].Controls.Add(numberList[i], 0, 2);
                panelList[i].Controls.Add(nameList[i], 0, 0);
                panelList[i].Controls.Add(trackBarList[i], 0, 1);
                panelList[i].Location = new Point(3, 3);
                panelList[i].Name = "panelList[i]";
                panelList[i].RowCount = 3;
                panelList[i].RowStyles.Add(new RowStyle());
                panelList[i].RowStyles.Add(new RowStyle());
                panelList[i].RowStyles.Add(new RowStyle());
                panelList[i].Size = new Size(111, 261);
                panelList[i].TabIndex = 2;

                numberList[i].Name = "numberTextBox" + i;
                numberList[i].Anchor = AnchorStyles.None;
                numberList[i].Location = new Point(40, 238);
                numberList[i].ReadOnly = true;
                numberList[i].Size = new Size(30, 20);
                numberList[i].TabIndex = 5;
                numberList[i].Text = "0";
                numberList[i].TextAlign = HorizontalAlignment.Center;


                nameList[i].Name = "nameTextBox" + i;
                nameList[i].Text = "Google Chrome " + (i + 1);
                nameList[i].Anchor = AnchorStyles.None;
                nameList[i].Location = new Point(3, 3);
                nameList[i].ReadOnly = true;
                nameList[i].Size = new Size(105, 20);
                nameList[i].TabIndex = 4;
                nameList[i].TextAlign = HorizontalAlignment.Center;

                trackBarList[i].Name = "trackBar" + i;
                trackBarList[i].Value = 0;
                trackBarList[i].Anchor = AnchorStyles.None;
                trackBarList[i].LargeChange = 10;
                trackBarList[i].Location = new Point(33, 29);
                trackBarList[i].Maximum = 100;
                trackBarList[i].Orientation = Orientation.Vertical;
                trackBarList[i].Size = new Size(45, 200);
                trackBarList[i].SmallChange = 5;
                trackBarList[i].TabIndex = 1;
                trackBarList[i].TickFrequency = 10;
                trackBarList[i].Scroll += new EventHandler(TrackBar_Scroll);

            }

        }

        public void ChangeTrackBarAt(int i,string name, int value )
        {
            try
            {
                nameList[i].Text = name;
                trackBarList[i].Value = value;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void ChangeTrackBarColorAt(int i, Color color)
        {
            try
            {
                trackBarList[i].BackColor = color;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ChangeEveryTrackBarColor(Color color)
        {
            try
            {
                for (int i = 0; i < trackBarNumber; i++)
                {
                    trackBarList[i].BackColor = color;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void ChangeBackgroundColor()
        {
            try
            {
                MainPanel.BackColor = BackgroundColor;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void SetPositionAndSize()
        {
            //float scaleX = ((float)this.NewWidth / this.BaseWidth);
            //float scaleY = ((float)formNewHeight / formBaseHeight);
            //this.Scale(new SizeF(scaleX, scaleY));

        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {

            TrackBar tkbar = sender as TrackBar;

            int i = int.Parse(tkbar.Name.Substring(8));

            numberList[i].Text = tkbar.Value.ToString();

        }
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    SetPositionAndSize();
        //}


        //private Size oldSize;
        //private void Form1_Load(object sender, EventArgs e) => oldSize = Size;

        //protected override void OnResize(System.EventArgs e)
        //{
        //    base.OnResize(e);

        //    foreach (Control cnt in Controls)
        //        ResizeAll(cnt, Size);

        //    oldSize = Size;
        //}
        //private void ResizeAll(Control control, Size newSize)
        //{
        //    int width = newSize.Width - oldSize.Width;
        //    control.Left += (control.Left * width) / oldSize.Width;
        //    control.Width += (control.Width * width) / oldSize.Width;

        //    int height = newSize.Height - oldSize.Height;
        //    control.Top += (control.Top * height) / oldSize.Height;
        //    control.Height += (control.Height * height) / oldSize.Height;
        //}




    }
}
