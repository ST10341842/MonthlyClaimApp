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
    /// Interaction logic for AcademicManager.xaml
    /// </summary>
    public partial class AcademicManager : Window
    {
        public AcademicManager()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void AM_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AcademicManager window = new AcademicManager();
            window.Show();
        }
    }
}
