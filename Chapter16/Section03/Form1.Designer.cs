namespace Section03 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.bt_16_6 = new System.Windows.Forms.Button();
            this.終了 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_16_7 = new System.Windows.Forms.Button();
            this.bt_16_8 = new System.Windows.Forms.Button();
            this.bt_16_9 = new System.Windows.Forms.Button();
            this.終了.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_16_6
            // 
            this.bt_16_6.Location = new System.Drawing.Point(115, 53);
            this.bt_16_6.Name = "bt_16_6";
            this.bt_16_6.Size = new System.Drawing.Size(191, 23);
            this.bt_16_6.TabIndex = 0;
            this.bt_16_6.Text = "イベントハンドラを非同期にする";
            this.bt_16_6.UseVisualStyleBackColor = true;
            this.bt_16_6.Click += new System.EventHandler(this.bt_16_6_Click);
            // 
            // 終了
            // 
            this.終了.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.終了.Location = new System.Drawing.Point(0, 428);
            this.終了.Name = "終了";
            this.終了.Size = new System.Drawing.Size(800, 22);
            this.終了.TabIndex = 1;
            this.終了.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // bt_16_7
            // 
            this.bt_16_7.Location = new System.Drawing.Point(115, 100);
            this.bt_16_7.Name = "bt_16_7";
            this.bt_16_7.Size = new System.Drawing.Size(191, 23);
            this.bt_16_7.TabIndex = 2;
            this.bt_16_7.Text = "イベントハンドラを非同期にする（２）";
            this.bt_16_7.UseVisualStyleBackColor = true;
            this.bt_16_7.Click += new System.EventHandler(this.bt_16_7_Click);
            // 
            // bt_16_8
            // 
            this.bt_16_8.Location = new System.Drawing.Point(115, 154);
            this.bt_16_8.Name = "bt_16_8";
            this.bt_16_8.Size = new System.Drawing.Size(191, 23);
            this.bt_16_8.TabIndex = 3;
            this.bt_16_8.Text = "button1";
            this.bt_16_8.UseVisualStyleBackColor = true;
            this.bt_16_8.Click += new System.EventHandler(this.bt_16_8_Click);
            // 
            // bt_16_9
            // 
            this.bt_16_9.Location = new System.Drawing.Point(112, 228);
            this.bt_16_9.Name = "bt_16_9";
            this.bt_16_9.Size = new System.Drawing.Size(182, 23);
            this.bt_16_9.TabIndex = 4;
            this.bt_16_9.Text = "button1";
            this.bt_16_9.UseVisualStyleBackColor = true;
            this.bt_16_9.Click += new System.EventHandler(this.bt_16_9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_16_9);
            this.Controls.Add(this.bt_16_8);
            this.Controls.Add(this.bt_16_7);
            this.Controls.Add(this.終了);
            this.Controls.Add(this.bt_16_6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.終了.ResumeLayout(false);
            this.終了.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_16_6;
        private System.Windows.Forms.StatusStrip 終了;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button bt_16_7;
        private System.Windows.Forms.Button bt_16_8;
        private System.Windows.Forms.Button bt_16_9;
    }
}

