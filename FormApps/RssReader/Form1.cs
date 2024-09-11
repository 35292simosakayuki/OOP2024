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
using System.Xml.Linq;
using Microsoft.Web.WebView2.Core;
namespace RssReader {
    
    public partial class Form1 : Form {
        private List<ItemData>items;
        private List<CategoryUrlPair> cateGoryUrlPairs;

        public Form1() {
            InitializeComponent();
            InitializecatagoryUrlPairs();
            MessageBox.Show("カテゴリ選択またはURLを入力して取得ボタンを押す\n"+
                "お気に入り名称とURLを入力して登録ボタンを押す");
            cbRssUrl.DropDownStyle=ComboBoxStyle.DropDown;
            cbRssUrl.SelectedIndex=-1;
            cbRssUrl.Text="";
        }

        private void InitializecatagoryUrlPairs() {
            cateGoryUrlPairs= new List<CategoryUrlPair> {
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
                new CategoryUrlPair("主要",""),
            }
        }
    }
}
