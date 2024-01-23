using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string _surname = "";
        public string _name = "";
        public string _title = "";
        public int _max_chars = 0;
        public bool _numbers = false;
        public bool _alpha = true;
        public bool _special_chars = false;

        public string alpha_small = "abcdefghijklmnopqrstuvwxyz";
        public string alpha_big = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string special_charset = "!@#$%^&*()_+-=";
        public string num_set = "0123456789";
        public string password = "";

        private void confirm(object sender, RoutedEventArgs e)
        {
            _surname = surname.Text;
            _name = name.Text;
            ComboBoxItem selectedItem = (ComboBoxItem)title.SelectedItem;

            if (selectedItem != null)
            {
                _title = selectedItem.Content.ToString();
            }

            MessageBox.Show("Dane pracownika: " + _name + " " + _surname + " " + _title + " Hasło: " + password);
        }

        private void generate_password(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            password = "";
            _max_chars = int.Parse(char_num.Text);
            _numbers = numbers.IsChecked.Value;
            _alpha = alpha.IsChecked.Value;
            _special_chars = special_chars.IsChecked.Value;

            string alphaSet = alpha_small + (_alpha ? alpha_big : "");

            int min_length = 0;
            min_length += _alpha ? 1 : 0;
            min_length += _numbers ? 1 : 0;
            min_length += _special_chars ? 1 : 0;

            if (_max_chars < min_length)
            {
                MessageBox.Show($"Minimalna długość hasła to {min_length} znaków.");
                return;
            }

            for (int i = 0; i < _max_chars; i++)
            {
                if (_alpha && password.Length < _max_chars)
                {
                    password += alphaSet[rand.Next(0, alphaSet.Length)];
                }

                if (_numbers && password.Length < _max_chars)
                {
                    password += num_set[rand.Next(0, num_set.Length)];
                }

                if (_special_chars && password.Length < _max_chars)
                {
                    password += special_charset[rand.Next(0, special_charset.Length)];
                }
            }

        MessageBox.Show(password);
        }
    }
}