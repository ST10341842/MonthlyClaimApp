using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonthlyClaimApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            HomePage window = new HomePage();
            window.Show();
        }

        private void LoginPCButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ProgramCoordinator window = new ProgramCoordinator();
            window.Show();
        }

        private void LoginAMButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AcademicManager window = new AcademicManager();
            window.Show();
        }
    }
}