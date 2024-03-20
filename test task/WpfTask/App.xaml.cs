using WpfTask.ViewModels;
using WpfTask.Stores;
using System.Windows;

namespace WpfTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            LoginViewModel mainViewModel = new LoginViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = mainViewModel
            };
            base.OnStartup(e);
        }
    }
}
