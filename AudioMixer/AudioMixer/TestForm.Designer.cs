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

        private void button1_Click(object sender, System.EventArgs e)
        {
            //  volumeMixerComp1.ChangeTrackBarColorAt(2, System.Drawing.Color.Black); 
         //volumeMixerComp1
            //  volumeMixerComp1.ChangeEveryTrackBarColor(System.Drawing.Color.Black); 
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.volumeMixerComp2 = new AudioMixer.VolumeMixerComp();
            this.SuspendLayout();
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(92, 32);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(100, 20);
            this.testBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // volumeMixerComp2
            // 
            this.volumeMixerComp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.volumeMixerComp2.BackgroundColor = System.Drawing.Color.Empty;
            this.volumeMixerComp2.Location = new System.Drawing.Point(357, 217);
            this.volumeMixerComp2.Name = "volumeMixerComp2";
            this.volumeMixerComp2.Size = new System.Drawing.Size(272, 328);
            this.volumeMixerComp2.TabIndex = 5;
            this.volumeMixerComp2.TrackBarNumber = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 687);
            this.Controls.Add(this.volumeMixerComp2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testBox);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.Button button1;
        private VolumeMixerComp volumeMixerComp2;
    }
}

