using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        List<Customer> _customers;
        private byte[] _imageData;
        public MainWindow() {
            InitializeComponent();
        }

        private void ResistButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                MessageBox.Show("名前を入力してください", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImagePath = _imageData,
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }

            ReadDatabase();
           
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;

            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }

            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AddressTextBox.Text;

            if (_imageData != null) {
                selectedCustomer.ImagePath = _imageData;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(selectedCustomer); // ここを修正
            }

            ReadDatabase(); // 更新後にデータを再読み込み
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
            }

            ReadDatabase();
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = (Customer)CustomerListView.SelectedItem;
            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                CustomerImage.Source = selectedCustomer.Image;

            } else {
                CustomerImage.Source = null;
            }

        }
        private void PictureButton_Click(object sender, RoutedEventArgs e) {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true) {
                _imageData = File.ReadAllBytes(openFileDialog.FileName);

                CustomerImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

            private void PictureClearButton_Click(object sender, RoutedEventArgs e) {
            CustomerImage.Source = null;
            _imageData = null;
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase();  // データベースから顧客情報を読み込み
        }

        private void AllClearButton_Click(object sender, RoutedEventArgs e) {
            ClearText();
            CustomerImage.Source = null;
            _imageData = null;
            CustomerListView.SelectedItem = null;
        }

        private void ClearText() {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
            SearchTextbox.Clear();
        }

    }
}
