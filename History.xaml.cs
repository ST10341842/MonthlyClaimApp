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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Window
    {
        public History()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            HomePage window = new HomePage();
            window.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            History window = new History();
            window.Show();
        }

        private void ViewProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewProfile window = new ViewProfile();
            window.Show();
        }

        private void LectureDashboard_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LectureClaim window = new LectureClaim();
            window.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            HomePage window = new HomePage();
            window.Show();
        }
    }
}
