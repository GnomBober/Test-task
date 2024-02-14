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
using Microsoft.EntityFrameworkCore;

namespace test_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            this.DataContext = viewModel;
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
            }
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OnLogin();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow window = new RegistrationWindow();
            window.Show();
        }

        private void logField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void passField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}