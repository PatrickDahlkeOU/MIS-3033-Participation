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

namespace WPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNames.Text = string.Empty;
            txtBirthdate.Text = string.Empty;
        }

        private void btnEnter(object sender, MouseEventArgs e)
        {
            GrdColor.Background = Brushes.Orange;
        }

        private void btnLeave(object sender, MouseEventArgs e)
        {
            GrdColor.Background = (Brush)new BrushConverter().ConvertFrom("#FF0F4C8E");
        }

        private void btnCalculateClick(object sender, RoutedEventArgs e)
        {
            string answerN = txtNames.Text;

            string answerD = txtBirthdate.Text;
            DateTime NumberBirth = Convert.ToDateTime(answerD);
            DateTime Today = DateTime.Today;

            TimeSpan result = Today - NumberBirth;

            MessageBox.Show("Thanks " + answerN + ", " + "you are " + ((result.TotalDays)/365) + " years old!");
        }
    }
}
