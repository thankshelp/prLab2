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

namespace num4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int s = 0;
        bool v = false;

        System.Windows.Threading.DispatcherTimer Timer;
        public MainWindow()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            s++;

            if (v == true)
            {
                lb.Content = "";
                if (hour.IsChecked == true)
                    lb.Content += (s / 3600).ToString();
                if (min.IsChecked == true)
                    lb.Content += ":" + (s / 60).ToString();
                if (sec.IsChecked == true)
                    lb.Content += ":" + (s % 60).ToString();

            }

        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
            v = true;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            
            v = false; 
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            lb.Content = "";
            Timer.Stop();
            s = 0;
        }
    }
}
