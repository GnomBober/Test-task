using System.Text;
using System.Windows;
using WpfTask.ViewModels;

namespace WpfTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginViewModel viewModel = new LoginViewModel();
        public MainWindow()
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}