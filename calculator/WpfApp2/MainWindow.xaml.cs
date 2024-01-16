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

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] chars = { "+", "/", "-", "*" };
        bool is_second = false;
        string oper_char = "";
        int arg1 = 0, arg2 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (display.Text == "0")
            {
                display.Text = string.Empty;
                display.Text = btn.Content.ToString();
            }
            display.Text += btn.Content.ToString();

            for (int i = 0; i < chars.Length; i++)
            {
                if (btn.Content.ToString() == chars[i])
                {
                    is_second = true;
                    oper_char = chars[i];
                }
            }

            if (is_second == false)
            {
                arg1 = int.Parse(btn.Content.ToString());
            }
            else
            {
                bool isNumeric = int.TryParse(btn.Content.ToString(), out _);
                if(isNumeric)
                    arg2 = int.Parse(btn.Content.ToString());
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);

                if (display.Text.Length == 0)
                {
                    arg1 = 0;
                    is_second = false;
                }
                else
                {
                    char lastChar = display.Text[display.Text.Length - 1];
                    is_second = chars.Contains(lastChar.ToString());

                    if (!is_second)
                    {
                        int.TryParse(display.Text, out arg1);
                    }
                    else
                    {
                        int.TryParse(display.Text, out arg2);
                    }
                }
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            display.Text = "";
            arg1 = 0; arg2 = 0;
            oper_char = "?";
            is_second = false;
        }

        private void Finish(object sender, RoutedEventArgs e)
        {
            double final = 0.0;
            switch (oper_char)
            {
                case "+":
                    final = arg1 + arg2;
                    break;
                case "-":
                    final = arg1 - arg2;
                    break;
                case "*":
                    final = arg1 * arg2;
                    break;
                case "/":
                    final = (double)(arg1 / arg2);
                    break;
                default:
                    return;
            }

            display.Text = final.ToString();
        }
    }
}
