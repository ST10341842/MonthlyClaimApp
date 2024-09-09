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
    /// Interaction logic for ProgramCoordinator.xaml
    /// </summary>
    public partial class ProgramCoordinator : Window
    {
        public ProgramCoordinator()
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

        private void Coordinator_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProgramCoordinator window = new ProgramCoordinator();
            window.Show();
        }
    }
}
