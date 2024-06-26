namespace CarReportSystem {
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
            label1 = new Label();
            label2 = new Label();
            cbAuther = new ComboBox();
            dpt = new DateTimePicker();
            label3 = new Label();
            cbCarName = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            label6 = new Label();
            label7 = new Label();
            btAddReport = new Button();
            button4 = new Button();
            btDeleteReport = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            dgvCarReport = new PictureBox();
            btModiffyReport = new Button();
            pbPicture = new PictureBox();
            button8 = new Button();
            btReportSave = new Button();
            groupBox1 = new GroupBox();
            rbtoyota = new RadioButton();
            rbnissan = new RadioButton();
            rbhonda = new RadioButton();
            rbsubaru = new RadioButton();
            radioButton5 = new RadioButton();
            rbinport = new RadioButton();
            tbReport = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            btReportOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15F);
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15F);
            label2.Location = new Point(10, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // cbAuther
            // 
            cbAuther.FormattingEnabled = true;
            cbAuther.Location = new Point(89, 79);
            cbAuther.Name = "cbAuther";
            cbAuther.Size = new Size(238, 23);
            cbAuther.TabIndex = 1;
            // 
            // dpt
            // 
            dpt.Font = new Font("Yu Gothic UI", 15F);
            dpt.Location = new Point(89, 27);
            dpt.Name = "dpt";
            dpt.Size = new Size(175, 34);
            dpt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 17F);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // cbCarName
            // 
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(89, 203);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(238, 23);
            cbCarName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 17F);
            label4.Location = new Point(19, 195);
            label4.Name = "label4";
            label4.Size = new Size(60, 31);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14F);
            label5.Location = new Point(513, 35);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 0;
            label5.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(609, 46);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 3;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(690, 46);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 3;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15F);
            label6.Location = new Point(12, 294);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 0;
            label6.Text = "レポート";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 17F);
            label7.Location = new Point(-63, 427);
            label7.Name = "label7";
            label7.Size = new Size(60, 31);
            label7.TabIndex = 0;
            label7.Text = "車名";
            // 
            // btAddReport
            // 
            btAddReport.Location = new Point(513, 277);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(75, 23);
            btAddReport.TabIndex = 3;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(609, 277);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "修正";
            button4.UseVisualStyleBackColor = true;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Location = new Point(690, 277);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 23);
            btDeleteReport.TabIndex = 3;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 17F);
            label8.Location = new Point(19, 195);
            label8.Name = "label8";
            label8.Size = new Size(60, 31);
            label8.TabIndex = 0;
            label8.Text = "車名";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(513, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 201);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI", 17F);
            label9.Location = new Point(17, 376);
            label9.Name = "label9";
            label9.Size = new Size(60, 31);
            label9.TabIndex = 0;
            label9.Text = "一覧";
            // 
            // dgvCarReport
            // 
            dgvCarReport.BackColor = SystemColors.ActiveCaption;
            dgvCarReport.Location = new Point(89, 376);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.Size = new Size(572, 191);
            dgvCarReport.TabIndex = 4;
            dgvCarReport.TabStop = false;
            // 
            // btModiffyReport
            // 
            btModiffyReport.Location = new Point(609, 277);
            btModiffyReport.Name = "btModiffyReport";
            btModiffyReport.Size = new Size(75, 23);
            btModiffyReport.TabIndex = 3;
            btModiffyReport.Text = "修正";
            btModiffyReport.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = SystemColors.ActiveCaption;
            pbPicture.Location = new Point(513, 70);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(252, 201);
            pbPicture.TabIndex = 4;
            pbPicture.TabStop = false;
            // 
            // button8
            // 
            button8.Location = new Point(-613, 756);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 3;
            button8.Text = "追加";
            button8.UseVisualStyleBackColor = true;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 15F);
            btReportSave.Location = new Point(7, 527);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(75, 40);
            btReportSave.TabIndex = 3;
            btReportSave.Text = "保存...";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbinport);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(rbsubaru);
            groupBox1.Controls.Add(rbhonda);
            groupBox1.Controls.Add(rbnissan);
            groupBox1.Controls.Add(rbtoyota);
            groupBox1.Location = new Point(101, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 31);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "　　トヨタ　　日産　　ホンダ　　スバル　　輸入車　　その他";
            // 
            // rbtoyota
            // 
            rbtoyota.AutoSize = true;
            rbtoyota.Location = new Point(17, 0);
            rbtoyota.Name = "rbtoyota";
            rbtoyota.Size = new Size(14, 13);
            rbtoyota.TabIndex = 0;
            rbtoyota.TabStop = true;
            rbtoyota.UseVisualStyleBackColor = true;
            // 
            // rbnissan
            // 
            rbnissan.AutoSize = true;
            rbnissan.Location = new Point(68, 0);
            rbnissan.Name = "rbnissan";
            rbnissan.Size = new Size(14, 13);
            rbnissan.TabIndex = 0;
            rbnissan.TabStop = true;
            rbnissan.UseVisualStyleBackColor = true;
            // 
            // rbhonda
            // 
            rbhonda.AutoSize = true;
            rbhonda.Location = new Point(110, 0);
            rbhonda.Name = "rbhonda";
            rbhonda.Size = new Size(14, 13);
            rbhonda.TabIndex = 0;
            rbhonda.TabStop = true;
            rbhonda.UseVisualStyleBackColor = true;
            // 
            // rbsubaru
            // 
            rbsubaru.AutoSize = true;
            rbsubaru.Location = new Point(165, 0);
            rbsubaru.Name = "rbsubaru";
            rbsubaru.Size = new Size(14, 13);
            rbsubaru.TabIndex = 0;
            rbsubaru.TabStop = true;
            rbsubaru.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(221, 0);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(14, 13);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // rbinport
            // 
            rbinport.AutoSize = true;
            rbinport.Location = new Point(280, 0);
            rbinport.Name = "rbinport";
            rbinport.Size = new Size(14, 13);
            rbinport.TabIndex = 0;
            rbinport.TabStop = true;
            rbinport.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(89, 259);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(355, 111);
            tbReport.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(608, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "開く...";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 259);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 111);
            textBox1.TabIndex = 6;
            // 
            // btReportOpen
            // 
            btReportOpen.Font = new Font("Yu Gothic UI", 15F);
            btReportOpen.Location = new Point(8, 464);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(75, 45);
            btReportOpen.TabIndex = 3;
            btReportOpen.Text = "開く...";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(textBox1);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(pictureBox2);
            Controls.Add(btPicDelete);
            Controls.Add(btReportSave);
            Controls.Add(btModiffyReport);
            Controls.Add(btDeleteReport);
            Controls.Add(button4);
            Controls.Add(button8);
            Controls.Add(btReportOpen);
            Controls.Add(button1);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(dpt);
            Controls.Add(cbCarName);
            Controls.Add(cbAuther);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbAuther;
        private DateTimePicker dpt;
        private Label label3;
        private ComboBox cbCarName;
        private Label label4;
        private Label label5;
        private Button btPicOpen;
        private Button btPicDelete;
        private Label label6;
        private Label label7;
        private Button btAddReport;
        private Button button4;
        private Button btDeleteReport;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label9;
        private PictureBox dgvCarReport;
        private Button btModiffyReport;
        private PictureBox pbPicture;
        private Button button7;
        private Button button8;
        private Button btReportSave;
        private GroupBox groupBox1;
        private RadioButton rbtoyota;
        private RadioButton rbinport;
        private RadioButton radioButton5;
        private RadioButton rbsubaru;
        private RadioButton rbhonda;
        private RadioButton rbnissan;
        private TextBox tbReport;
        private Button button1;
        private TextBox textBox1;
        private Button btReportOpen;
    }
}
