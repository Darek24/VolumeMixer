namespace TestFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.volumeMixerComp1 = new AudioMixer.VolumeMixerComp();
            this.volumeMixerComp2 = new AudioMixer.VolumeMixerComp();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volumeMixerComp1
            // 
            this.volumeMixerComp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeMixerComp1.BackgroundColor = System.Drawing.Color.Empty;
            this.volumeMixerComp1.Location = new System.Drawing.Point(674, 120);
            this.volumeMixerComp1.Name = "volumeMixerComp1";
            this.volumeMixerComp1.NamesArray = new string[0];
            this.volumeMixerComp1.Size = new System.Drawing.Size(8, 8);
            this.volumeMixerComp1.TabIndex = 0;
            this.volumeMixerComp1.TickFrequencyValue = 0;
            this.volumeMixerComp1.TrackBarColor = System.Drawing.Color.Empty;
            this.volumeMixerComp1.TrackBarNameColor = System.Drawing.Color.Empty;
            this.volumeMixerComp1.TrackBarNumber = 0;
            this.volumeMixerComp1.TrackBarValueColor = System.Drawing.Color.Empty;
            this.volumeMixerComp1.ValuesArray = new int[0];
            // 
            // volumeMixerComp2
            // 
            this.volumeMixerComp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeMixerComp2.BackgroundColor = System.Drawing.Color.Aqua;
            this.volumeMixerComp2.Location = new System.Drawing.Point(153, 161);
            this.volumeMixerComp2.Name = "volumeMixerComp2";
            this.volumeMixerComp2.NamesArray = new string[] {
        "Chrome",
        "Opera",
        "Egde",
        "Internet Explorer",
        "NetBeans",
        "Visual Studio",
        "Eclipse"};
            this.volumeMixerComp2.Size = new System.Drawing.Size(570, 314);
            this.volumeMixerComp2.TabIndex = 1;
            this.volumeMixerComp2.TickFrequencyValue = 50;
            this.volumeMixerComp2.TrackBarColor = System.Drawing.Color.Yellow;
            this.volumeMixerComp2.TrackBarNameColor = System.Drawing.Color.Magenta;
            this.volumeMixerComp2.TrackBarNumber = 5;
            this.volumeMixerComp2.TrackBarValueColor = System.Drawing.Color.Green;
            this.volumeMixerComp2.ValuesArray = new int[] {
        -100,
        150,
        30,
        70,
        25,
        13,
        0};
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Change Multiple Names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Change Multiple Values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Change one column";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(364, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 40);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add one column";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(153, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 40);
            this.button5.TabIndex = 12;
            this.button5.Text = "Remove one column";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tick Freqeuncy ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(773, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(686, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Change Frequency";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 551);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volumeMixerComp2);
            this.Controls.Add(this.volumeMixerComp1);
            this.Name = "Form1";
            this.Text = "Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AudioMixer.VolumeMixerComp volumeMixerComp1;
        private AudioMixer.VolumeMixerComp volumeMixerComp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
    }
}

