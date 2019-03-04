﻿using System;
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
            lb.Content = DateTime.Now.Second;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }
    }
}
