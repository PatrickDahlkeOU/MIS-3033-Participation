using System.Windows;
using System.Windows.Controls;

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

namespace WPF_First_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblhidden.Content = string.Empty;
            txtTest1.Clear();


        }

        private void Submit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked me!");
            MessageBox.Show("Thanks for clicking me!", "Clicked", MessageBoxButton.YesNo);
            lblhidden.Content = "Hello World";

            string answer = txtTest1.Text;
            double result = Convert.ToDouble(answer);

        }
    }
}
