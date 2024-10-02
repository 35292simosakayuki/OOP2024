﻿using System;

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wbRss)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRssName
            // 
            this.tbRssName.Location = new System.Drawing.Point(132, 42);
            this.tbRssName.Name = "tbRssName";
            this.tbRssName.Size = new System.Drawing.Size(430, 19);
            this.tbRssName.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(568, 18);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(30, 134);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(749, 124);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbRss
            // 
            this.wbRss.AllowExternalDrop = true;
            this.wbRss.CreationProperties = null;
            this.wbRss.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbRss.Location = new System.Drawing.Point(30, 263);
            this.wbRss.Name = "wbRss";
            this.wbRss.Size = new System.Drawing.Size(749, 382);
            this.wbRss.TabIndex = 4;
            this.wbRss.ZoomFactor = 1D;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(132, 18);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(430, 20);
            this.cbRssUrl.TabIndex = 5;
            // 
            // btJoin
            // 
            this.btJoin.Location = new System.Drawing.Point(571, 47);
            this.btJoin.Name = "btJoin";
            this.btJoin.Size = new System.Drawing.Size(72, 19);
            this.btJoin.TabIndex = 6;
            this.btJoin.Text = "登録";
            this.btJoin.UseVisualStyleBackColor = true;
            this.btJoin.Click += new System.EventHandler(this.btJoin_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(649, 47);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(72, 19);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btFavorite
            // 
            this.btFavorite.Location = new System.Drawing.Point(568, 73);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(72, 19);
            this.btFavorite.TabIndex = 8;
            this.btFavorite.Text = "お気に入り";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // lbFavoriteItems
            // 
            this.lbFavoriteItems.FormattingEnabled = true;
            this.lbFavoriteItems.ItemHeight = 12;
            this.lbFavoriteItems.Location = new System.Drawing.Point(39, 66);
            this.lbFavoriteItems.Name = "lbFavoriteItems";
            this.lbFavoriteItems.Size = new System.Drawing.Size(523, 52);
            this.lbFavoriteItems.TabIndex = 9;
            this.lbFavoriteItems.SelectedIndexChanged += new System.EventHandler(this.lbFavoriteItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "URL又はお気に入り名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "お気に入り名称:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFavoriteItems);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btJoin);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.wbRss);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbRssName);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

