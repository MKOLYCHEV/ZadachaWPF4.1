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

namespace ZadachaWPF4._1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resEuro = rateEuro * sumEuro;
            resSumE.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rateH.Text);
            double sumHryvnia = Convert.ToDouble(sumH.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSumH.Text = resHryvnia.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateGBP = Convert.ToDouble(rateG.Text);
            double sumGBP = Convert.ToDouble(sumG.Text);
            double resGBP = rateGBP * sumGBP;
            resSumG.Text = resGBP.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double NumInch = Convert.ToDouble(numInch.Text);
            double ResInch = NumInch * 0.0254;
            resInch.Text = ResInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double NumFt = Convert.ToDouble(numFt.Text);
            double ResFt = NumFt * 0.3048;
            resFt.Text = ResFt.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double NumM = Convert.ToDouble(numM.Text);
            double ResM = NumM * 1609.34;
            resM.Text = ResM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double NumV = Convert.ToDouble(numV.Text);
            double ResV = NumV * 1066.8;
            resV.Text = ResV.ToString();
        }
    }
}
