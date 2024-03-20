using System.Windows;
using WpfTask.Stores;
using WpfTask.ViewModels;
using WpfTask.Services;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfTask.Commands
{
    internal class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _viewModel;
        private readonly NavigationService<AccountViewModel> _navigationService;

        public LoginCommand(LoginViewModel viewModel, NavigationService<AccountViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show($"Logging in {_viewModel.UserName}...");

            _navigationService.Navigate();
        }
    }
}
