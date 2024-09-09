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
using System.Windows.Shapes;

namespace MonthlyClaimApp
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();  // Close the current MainWindow, effectively exiting the application
        }

        private void MakeClaim_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LectureClaim window = new LectureClaim();
            window.Show();
        }

        private void ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewProfile window = new ViewProfile();
            window.Show();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            History window = new History();
            window.Show();
        }
    }
}
