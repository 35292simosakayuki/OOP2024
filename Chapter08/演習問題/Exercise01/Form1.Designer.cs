﻿namespace Exercise01 {
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
            btEx8_1 = new Button();
            tbDisp = new TextBox();
            btEx8_2_Click = new Button();
            SuspendLayout();
            // 
            // btEx8_1
            // 
            btEx8_1.Font = new Font("Yu Gothic UI", 22F);
            btEx8_1.Location = new Point(24, 12);
            btEx8_1.Name = "btEx8_1";
            btEx8_1.Size = new Size(144, 52);
            btEx8_1.TabIndex = 0;
            btEx8_1.Text = "button1";
            btEx8_1.UseVisualStyleBackColor = true;
            btEx8_1.Click += btEx8_1_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 22F);
            tbDisp.Location = new Point(38, 166);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(380, 255);
            tbDisp.TabIndex = 1;
            // 
            // btEx8_2_Click
            // 
            btEx8_2_Click.Location = new Point(28, 80);
            btEx8_2_Click.Name = "btEx8_2_Click";
            btEx8_2_Click.Size = new Size(140, 53);
            btEx8_2_Click.TabIndex = 2;
            btEx8_2_Click.Text = "button2";
            btEx8_2_Click.UseVisualStyleBackColor = true;
            btEx8_2_Click.Click += btEx8_2_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btEx8_2_Click);
            Controls.Add(tbDisp);
            Controls.Add(btEx8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEx8_1;
        private TextBox tbDisp;
        private Button btEx8_2_Click;
    }
}
