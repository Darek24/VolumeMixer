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
            this.volumeMixerComp1 = new AudioMixer.VolumeMixerComp();
            this.SuspendLayout();
            // 
            // volumeMixerComp1
            // 
            this.volumeMixerComp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeMixerComp1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.volumeMixerComp1.Location = new System.Drawing.Point(230, 179);
            this.volumeMixerComp1.Name = "volumeMixerComp1";
            this.volumeMixerComp1.Size = new System.Drawing.Size(706, 350);
            this.volumeMixerComp1.TabIndex = 4;
            this.volumeMixerComp1.TrackBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.volumeMixerComp1.TrackBarNameColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.volumeMixerComp1.TrackBarNumber = 5;
            this.volumeMixerComp1.TrackBarValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.volumeMixerComp1);
            this.Name = "TestForm";
            this.Text = "Volume Mixer Display";
            this.ResumeLayout(false);

        }

        #endregion
        private VolumeMixerComp volumeMixerComp1;
    }
}

