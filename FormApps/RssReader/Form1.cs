using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Web.WebView2.Core;
using Windows.Data.Xml.Dom;
namespace RssReader {

    public partial class Form1 : Form {
        private List<ItemData> items;
        private List<CategoryUrlPair> cateGoryUrlPairs;
        private List<ItemData> favoriteItems;

        public Form1() {
            InitializeComponent();
            InitializecatagoryUrlPairs();
            MessageBox.Show("カテゴリ選択またはURLを入力して取得ボタンを押す\n" +
                "お気に入り名称とURLを入力して登録ボタンを押す");
            cbRssUrl.DropDownStyle = ComboBoxStyle.DropDown;
            cbRssUrl.SelectedIndex = -1;
            cbRssUrl.Text = "";
        }

        private void InitializecatagoryUrlPairs() {
            cateGoryUrlPairs = new List<CategoryUrlPair> {
             new CategoryUrlPair("主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml"),
                new CategoryUrlPair("国内","https://news.yahoo.co.jp/rss/topics/domestic.xml"),
                new CategoryUrlPair("国際","https://news.yahoo.co.jp/rss/topics/world.xml"),
                new CategoryUrlPair("経済","https://news.yahoo.co.jp/rss/topics/business.xml"),
                new CategoryUrlPair("エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml"),
                new CategoryUrlPair("スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml"),
                new CategoryUrlPair("IT","https://news.yahoo.co.jp/rss/topics/it.xml"),
                new CategoryUrlPair("科学","https://news.yahoo.co.jp/rss/topics/science.xml"),
                new CategoryUrlPair("地域","https://news.yahoo.co.jp/rss/topics/local.xml"),
        };
            cbRssUrl.DataSource = cateGoryUrlPairs;
            cbRssUrl.DisplayMember = "Category";
            cbRssUrl.ValueMember = "Url";
        }

        private async void btGet_Click(object sender, EventArgs e) {
            string selectedUrl;

            if (cbRssUrl.SelectedItem is CategoryUrlPair selectedPair) {
                selectedUrl = selectedPair.Url;
            } else {
                selectedUrl = cbRssUrl.Text;
            }

            if (!string.IsNullOrWhiteSpace(selectedUrl)) {
                try {
                    using (var wc = new WebClient()) {
                        wc.Encoding = Encoding.UTF8;
                        var rssData = await wc.DownloadStringTaskAsync(selectedUrl);

                        try {
                            var xdoc = XDocument.Parse(rssData);

                            items = xdoc.Descendants("item") // "item"に修正
                                .Select(item => new ItemData {
                                    Title = item.Element("title")?.Value ?? "タイトルなし",
                                    Link = item.Element("link")?.Value ?? string.Empty,
                                }).ToList();

                            lbRssTitle.Invoke(new Action(() => {
                                lbRssTitle.Items.Clear();
                                foreach (var item in items) {
                                    lbRssTitle.Items.Add(item.Title);
                                }
                            }));
                        }
                        catch (XmlException xmlEx) {
                            MessageBox.Show($"RSSデータのXML解析エラー: {xmlEx.Message}", "XMLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (WebException webEx) {
                    MessageBox.Show($"URLの取得中にエラーが発生しました: {webEx.Message}", "URLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show($"エラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("URLを入力またはカテゴリを選択してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex >= 0) {
                var selectedItem = items[lbRssTitle.SelectedIndex];
                if (!string.IsNullOrEmpty(selectedItem.Link)) {
                    try {
                        // URLが有効な形式か確認
                        var url = new Uri(selectedItem.Link);
                        wbRss.Source = url; // WebView2では Source プロパティを使用
                    }
                    catch (UriFormatException) {
                        MessageBox.Show("無効なURLです。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        public class CategoryUrlPair {
            public string Category { get; set; }
            public string Url { get; set; }

            public CategoryUrlPair(string category, string url) {
                Category = category;
                Url = url;
            }
        }

        private void btJoin_Click(object sender, EventArgs e) {
            string categoryName = tbRssName.Text;
            string url = cbRssUrl.Text;

            if (string.IsNullOrWhiteSpace(categoryName)) {
                MessageBox.Show("カテゴリ名を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(url)) {
                MessageBox.Show("URLを入力してください。", "URLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // URLが正しい形式かチェックする
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
                MessageBox.Show("無効なURL形式です。正しいURLを入力してください。", "URLエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newPair = new CategoryUrlPair(categoryName, url);
            cateGoryUrlPairs.Add(newPair);

            cbRssUrl.DataSource = null;
            cbRssUrl.DataSource = cateGoryUrlPairs;
            cbRssUrl.DisplayMember = "Category";
            cbRssUrl.ValueMember = "Url";

            tbRssName.Text = "";
            cbRssUrl.Text = "";

            MessageBox.Show("登録しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private async void Form1_Load(object sender, EventArgs e) {
            await wbRss.EnsureCoreWebView2Async(null);
        }
        private void btDelete_Click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex >= 0) {
                int indexToRemove = lbRssTitle.SelectedIndex;
                items.RemoveAt(indexToRemove); 
                lbRssTitle.Items.RemoveAt(indexToRemove); 
            } else {
                MessageBox.Show("削除するアイテムを選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btFavorite_Click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex >= 0) {
                var selectedItem = items[lbRssTitle.SelectedIndex];

                
                if (!favoriteItems.Any(f => f.Link == selectedItem.Link)) {
                    favoriteItems.Add(selectedItem);
                    MessageBox.Show($"{selectedItem.Title} をお気に入りに追加しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    UpdateFavoriteItemsList();
                } else {
                    MessageBox.Show($"{selectedItem.Title} はすでにお気に入りに登録されています。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("お気に入りに追加するアイテムを選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateFavoriteItemsList() {
            lbFavoriteItems.Items.Clear();
            foreach (var item in favoriteItems) {
                lbFavoriteItems.Items.Add(item.Title);
            }
        }
        private void lbFavoriteItems_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbFavoriteItems.SelectedIndex >= 0) {
                var selectedItem = favoriteItems[lbFavoriteItems.SelectedIndex];
                if (!string.IsNullOrEmpty(selectedItem.Link)) {
                    try {
                        var url = new Uri(selectedItem.Link);
                        wbRss.Source = url; 
                    }
                    catch (UriFormatException) {
                        MessageBox.Show("無効なURLです。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }


}
