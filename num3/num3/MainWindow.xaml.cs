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

namespace num3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stack.Items.Add("Mercury");
            stack.Items.Add("Venus");
            stack.Items.Add("Earth");
            stack.Items.Add("Mars");
            stack.Items.Add("Jupiter");
            stack.Items.Add("Saturn");
            stack.Items.Add("Uranus");
            stack.Items.Add("Neptune");
        }

        private void Stack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (stack.SelectedIndex == 0)
                info.Content = "Distance from the Sun: 57,910,000 km";
            if (stack.SelectedIndex == 1)
                info.Content = "Distance from the Sun: 108,200,000 km";
            if (stack.SelectedIndex == 2)
                info.Content = "Distance from the Sun: 149 600 000 km";
            if (stack.SelectedIndex == 3)
                info.Content = "Distance from the Sun: 227 900 000 km";
            if (stack.SelectedIndex == 4)
                info.Content = "Distance from the Sun: 778 500 000 km";
            if (stack.SelectedIndex == 5)
                info.Content = "Distance from the Sun: 1,434E9 km";
            if (stack.SelectedIndex == 6)
                info.Content = "Distance from the Sun: 2,871E9 km";
            if (stack.SelectedIndex == 7)
                info.Content = "Distance from the Sun: 4.495E9 km";
        }
    }
}
