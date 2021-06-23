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

namespace zadanie1Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double a, b;
        private void suma_Click(object sender, RoutedEventArgs e)
        {
            
            a = Convert.ToDouble(text1.Text);
            b = Convert.ToDouble(text2.Text);
            wynik.Content = "Wynik sumy: "+a+" + "+b+" = "+(a + b);
        }

        private void iloczyn_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(text1.Text);
            b = Convert.ToDouble(text2.Text);
            wynik.Content = "Wynik iloczynu: " + a + " * " + b + " = " + (a * b);
        }

        private void iloraz_Click(object sender, RoutedEventArgs e)
        {
            if (b != 0)
            {
                a = Convert.ToDouble(text1.Text);
                b = Convert.ToDouble(text2.Text);
                wynik.Content = "Wynik ilorazu: " + a + " / " + b + " = " + (a / b);
            }
            else 
            {
                MessageBox.Show("Nie dziel przez zero!");
            }
            
        }

        private void roznica_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(text1.Text);
            b = Convert.ToDouble(text2.Text);
            wynik.Content = "Wynik roznicy: " + a + " - " + b + " = " + (a - b);
        }
    }
}
