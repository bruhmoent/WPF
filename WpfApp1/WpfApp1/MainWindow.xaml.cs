using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double cena = 0;
        public string image_path = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sprawdz(object sender, RoutedEventArgs e)
        {
            if (poczt.IsChecked == true)
            {
                cena = 1;
                image_path = "/pocztowka.png";
            }

            if (list.IsChecked == true)
            {
                cena = 1.5;
                image_path = "/list.png";
            }

            if (paczka.IsChecked == true)
            {
                cena = 10.0;
                image_path = "/paczka.png";
            }

            obraz.Source = new BitmapImage(new Uri(image_path, UriKind.RelativeOrAbsolute));

            cenas.Content = "Cena: " + cena.ToString();
        }

        private void zatwierz(object sender, RoutedEventArgs e)
        {
            string komunikat = "Dane przesyłki zostały wprowadzone";
            int counter = 0;
            string kod = kod_poczt.Text;

            for (int i = 0; i < kod.Length; i++)
            {
                char c = kod[i];

                if (Char.IsDigit(c) == true)
                {
                    counter++;
                }
            }

            if (counter != 5)
            {
                komunikat = "Kod pocztowy powinien się składać z samych cyfr";
            }

            if (kod.Length != 5)
            {
                komunikat = "Nieprawidłowa liczba cyfr w kodzie podpocztowym";
            }

            MessageBox.Show(komunikat);
        }
    }
}
