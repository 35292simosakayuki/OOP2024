﻿namespace BallApp {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbBall = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbBall).BeginInit();
            SuspendLayout();
            // 
            // pbBall
            // 
            pbBall.BackgroundImageLayout = ImageLayout.None;
            pbBall.BorderStyle = BorderStyle.FixedSingle;
            pbBall.Image = (Image)resources.GetObject("pbBall.Image");
            pbBall.Location = new Point(44, 12);
            pbBall.Name = "pbBall";
            pbBall.Size = new Size(472, 456);
            pbBall.TabIndex = 0;
            pbBall.TabStop = false;
            pbBall.WaitOnLoad = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(pbBall);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbBall;
        private System.Windows.Forms.Timer timer1;
    }
}
