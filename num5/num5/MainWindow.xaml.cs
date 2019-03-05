using System;
using System.Collections.Generic;
using System.IO;
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

namespace num5
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

        private void Op_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = "Text documents (.txt)|*.txt";
            dlg.ShowDialog();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(dlg.FileName);

            while ((line = file.ReadLine()) != null)
            {
                lb.Items.Add(line);
            }
            file.Close();
        }

        private void Sv_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = "Text documents (.txt)|*.txt";
            dlg.ShowDialog();

            string[] line = lb.Items.OfType<string>().ToArray();

            using(StreamWriter file = new StreamWriter(dlg.FileName))
            {
                foreach (string str in line)
                    file.WriteLine(str);
            }
            lb.Items.Clear();
        }

        private void Clap_Click(object sender, RoutedEventArgs e)
        {
            lb.Items.Add(str.Text);

            str.Text = "";
        }
    }
}
