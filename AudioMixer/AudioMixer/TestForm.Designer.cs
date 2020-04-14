using System;

namespace AudioMixer
{
    partial class TestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.volumeMixerComp1 = new AudioMixer.VolumeMixerComp();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change TrackBars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // volumeMixerComp1
            // 
            this.volumeMixerComp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeMixerComp1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.volumeMixerComp1.Location = new System.Drawing.Point(177, 166);
            this.volumeMixerComp1.Name = "volumeMixerComp1";
            this.volumeMixerComp1.NamesArray = new string[] {
        "Opera",
        "Chrome",
        "Mozilla ",
        "Internet Explorer",
        "Egde",
        "NetBeans",
        "Visual Studio"};
            this.volumeMixerComp1.Size = new System.Drawing.Size(761, 364);
            this.volumeMixerComp1.TabIndex = 6;
            this.volumeMixerComp1.TickFrequencyValue = 5;
            this.volumeMixerComp1.TrackBarColor = System.Drawing.Color.MintCream;
            this.volumeMixerComp1.TrackBarNameColor = System.Drawing.Color.Gray;
            this.volumeMixerComp1.TrackBarNumber = 7;
            this.volumeMixerComp1.TrackBarValueColor = System.Drawing.Color.Lime;
            this.volumeMixerComp1.ValuesArray = new int[] {
        -130,
        5,
        120,
        53,
        23,
        39,
        0};
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.volumeMixerComp1);
            this.Controls.Add(this.button1);
            this.Name = "TestForm";
            this.Text = "Volume Mixer Display";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private VolumeMixerComp volumeMixerComp1;
    }
}

