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

namespace Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double s = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SliderAction(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double val = slider.Value;

            s = val;

            wartosc.Text = val.ToString();
        }

        private void zrob(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem1 = (ComboBoxItem)first.SelectedItem;
            ComboBoxItem typeItem2 = (ComboBoxItem)second.SelectedItem;
            string uno = typeItem1.Content.ToString();
            string dos = typeItem2.Content.ToString();

            double preserve = s;

            if (uno == "cm")
            {
                switch (dos)
                {
                    case "dm":
                        preserve /= 10;
                        break;
                    case "m":
                        preserve /= 100;
                        break;
                    case "km":
                        preserve /= 100000;
                        break;
                }
            }
            else if (uno == "dm")
            {
                switch (dos)
                {
                    case "cm":
                        preserve *= 10;
                        break;
                    case "m":
                        preserve /= 10;
                        break;
                    case "km":
                        preserve /= 10000;
                        break;
                }
            }
            else if (uno == "m")
            {
                switch (dos)
                {
                    case "cm":
                        preserve *= 100;
                        break;
                    case "dm":
                        preserve *= 10;
                        break;
                    case "km":
                        preserve /= 1000;
                        break;
                }
            }
            else if (uno == "km")
            {
                switch (dos)
                {
                    case "cm":
                        preserve /= 100000;
                        break;
                    case "dm":
                        preserve /= 10000;
                        break;
                    case "m":
                        preserve /= 1000;
                        break;
                }
            }

            aj.Source = new BitmapImage(new Uri("/glaggle.png", UriKind.RelativeOrAbsolute));

            field.Text = "Z " + s.ToString() + " " + uno + " na " + dos + ": " + preserve.ToString() + " " + dos;
        }
    }
}
