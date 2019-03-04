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

namespace _2._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MIN_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);

            double min = a - b;

            RES.Content = min;
        }

        private void UMN_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);

            double umn = a * b;

            RES.Content = umn;
        }

        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);

            double del = a / b;

            RES.Content = del;
        }

        private void SUM_Click(object sender, RoutedEventArgs e)
        {
            a = double.Parse(A.Text);
            b = double.Parse(B.Text);

            double sum = a + b;

            RES.Content = sum; 
        }
    }
}
