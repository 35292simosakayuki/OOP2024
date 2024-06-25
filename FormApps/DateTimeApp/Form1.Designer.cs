namespace DateTimeApp {
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
            dtpDate = new DateTimePicker();
            label1 = new Label();
            btDateCount = new Button();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            dtDayBefore = new Button();
            btDayafter = new Button();
            btbirthday = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(127, 45);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(138, 23);
            dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 1;
            label1.Text = "日付";
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(122, 83);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(205, 87);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDaycount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 22F);
            tbDisp.Location = new Point(33, 318);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(294, 47);
            tbDisp.TabIndex = 3;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 22F);
            nudDay.Location = new Point(33, 223);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 47);
            nudDay.TabIndex = 4;
            nudDay.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // dtDayBefore
            // 
            dtDayBefore.Font = new Font("Yu Gothic UI", 22F);
            dtDayBefore.Location = new Point(211, 197);
            dtDayBefore.Name = "dtDayBefore";
            dtDayBefore.Size = new Size(91, 47);
            dtDayBefore.TabIndex = 5;
            dtDayBefore.Text = "日前";
            dtDayBefore.UseVisualStyleBackColor = true;
            dtDayBefore.Click += dtDayBefore_Click;
            // 
            // btDayafter
            // 
            btDayafter.Font = new Font("Yu Gothic UI", 22F);
            btDayafter.Location = new Point(211, 250);
            btDayafter.Name = "btDayafter";
            btDayafter.Size = new Size(92, 45);
            btDayafter.TabIndex = 5;
            btDayafter.Text = "日後";
            btDayafter.UseVisualStyleBackColor = true;
            btDayafter.Click += btDayafter_Click;
            // 
            // btbirthday
            // 
            btbirthday.Font = new Font("Yu Gothic UI", 22F);
            btbirthday.Location = new Point(340, 197);
            btbirthday.Name = "btbirthday";
            btbirthday.Size = new Size(75, 56);
            btbirthday.TabIndex = 6;
            btbirthday.Text = "button1";
            btbirthday.UseVisualStyleBackColor = true;
            btbirthday.Click += btbirthday_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbirthday);
            Controls.Add(btDayafter);
            Controls.Add(dtDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Label label1;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button dtDayBefore;
        private Button btDayafter;
        private Button btbirthday;
    }
}
