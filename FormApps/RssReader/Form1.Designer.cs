using System;

namespace RssReader {
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
            this.tbRssName = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbRss = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btJoin = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btFavorite = new System.Windows.Forms.Button();
            this.lbFavoriteItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.wbRss)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRssName
            // 
            this.tbRssName.Location = new System.Drawing.Point(52, 53);
            this.tbRssName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRssName.Name = "tbRssName";
            this.tbRssName.Size = new System.Drawing.Size(696, 22);
            this.tbRssName.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(757, 22);
            this.btGet.Margin = new System.Windows.Forms.Padding(4);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(100, 29);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 15;
            this.lbRssTitle.Location = new System.Drawing.Point(40, 167);
            this.lbRssTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(997, 154);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbRss
            // 
            this.wbRss.AllowExternalDrop = true;
            this.wbRss.CreationProperties = null;
            this.wbRss.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbRss.Location = new System.Drawing.Point(40, 329);
            this.wbRss.Margin = new System.Windows.Forms.Padding(4);
            this.wbRss.Name = "wbRss";
            this.wbRss.Size = new System.Drawing.Size(999, 478);
            this.wbRss.TabIndex = 4;
            this.wbRss.ZoomFactor = 1D;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(52, 22);
            this.cbRssUrl.Margin = new System.Windows.Forms.Padding(4);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(696, 23);
            this.cbRssUrl.TabIndex = 5;
            // 
            // btJoin
            // 
            this.btJoin.Location = new System.Drawing.Point(761, 59);
            this.btJoin.Margin = new System.Windows.Forms.Padding(4);
            this.btJoin.Name = "btJoin";
            this.btJoin.Size = new System.Drawing.Size(96, 24);
            this.btJoin.TabIndex = 6;
            this.btJoin.Text = "登録";
            this.btJoin.UseVisualStyleBackColor = true;
            this.btJoin.Click += new System.EventHandler(this.btJoin_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(865, 59);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 24);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btFavorite
            // 
            this.btFavorite.Location = new System.Drawing.Point(757, 91);
            this.btFavorite.Margin = new System.Windows.Forms.Padding(4);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(96, 24);
            this.btFavorite.TabIndex = 8;
            this.btFavorite.Text = "お気に入り";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // lbFavoriteItems
            // 
            this.lbFavoriteItems.FormattingEnabled = true;
            this.lbFavoriteItems.ItemHeight = 15;
            this.lbFavoriteItems.Location = new System.Drawing.Point(52, 83);
            this.lbFavoriteItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbFavoriteItems.Name = "lbFavoriteItems";
            this.lbFavoriteItems.Size = new System.Drawing.Size(696, 64);
            this.lbFavoriteItems.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 760);
            this.Controls.Add(this.lbFavoriteItems);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btJoin);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.wbRss);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbRssName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wbRss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox tbRssName;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbRss;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btJoin;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.ListBox lbFavoriteItems;
    }
}

