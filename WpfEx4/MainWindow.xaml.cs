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

namespace WpfLab4._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            if (rate1.Text == null || sum1.Text == null)
            {
                resSum1.Text = "Ошибка";
            }
            double resDollar = rateDollar * sumDollar;
            resSum1.Text = resDollar.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            resSum2.Text = resEuro.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate3.Text);
            double sumGrivn = Convert.ToDouble(sum3.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSum3.Text = resGrivn.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateDrum = Convert.ToDouble(rate4.Text);
            double sumDrum = Convert.ToDouble(sum4.Text);
            double resDrum = rateDrum * sumDrum;
            resSum4.Text = resDrum.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double lengthInch = Convert.ToDouble(length1.Text);
            double resInch = lengthInch * 0.0254;
            meters1.Text = resInch.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double lengthFeet = Convert.ToDouble(length2.Text);
            double resFeet = lengthFeet * 0.3048;
            meters2.Text = resFeet.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double lengthMiles = Convert.ToDouble(length3.Text);
            double resMiles = lengthMiles * 1609.34;
            meters3.Text = resMiles.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double lengthVersts = Convert.ToDouble(length4.Text);
            double resVersts = lengthVersts * 1066.8;
            meters4.Text = resVersts.ToString();
        }
    }
}
