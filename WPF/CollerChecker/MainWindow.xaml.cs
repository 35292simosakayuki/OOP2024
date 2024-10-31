using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor;
        MyColor[] colorsTable;

        public MainWindow() {
            InitializeComponent();
            currentColor = new MyColor();
            currentColor.Color=Color.FromArgb(255, 0, 0, 0);
            DataContext=GetColorList();

        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public |BindingFlags.Static)
                .Select(i => new MyColor() { Color=(Color)i.GetValue(null), Name=i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color=Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            currentColor.Name=GetColorList().Where(c => c.Color.Equals(currentColor.Color)).Select(x=>x.Name).FirstOrDefault();

           // int i;
            //for (i = 0; i<colorsTable.Length; i++) {
            //    if (colorsTable[i].Color.Equals(currentColor.Color)) {
            //        currentColor.Name=colorsTable[i].Name;
             //       break;
            //    }
           // }
            //colorSelectComboBox.SelectedIndex = i;
            colorArea.Background=new SolidColorBrush(currentColor.Color);


        }
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです", "ColorChecker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background=new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }
        private void setSliderValue(Color color) {
            rSlider.Value=color.R; gSlider.Value=color.G; bSlider.Value=color.B;
        }
        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var tempCurrentColor = currentColor=(MyColor)((ComboBox)sender).SelectedItem;
        }
        private void removeButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedItem != null) {
                stockList.Items.Remove(stockList.SelectedItem);
            } else {
                MessageBox.Show("削除するアイテムを選択してください", "ColorChecker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        }
}
