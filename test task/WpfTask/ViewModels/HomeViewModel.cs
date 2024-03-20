using WpfTask.Stores;
using System.Windows.Input;
using WpfTask.Commands;
using WpfTask.Services;

namespace WpfTask.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";
        public ICommand NavigateLoginCommand { get; }

        /*public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(new NavigationService<LoginViewModel>(
                navigationStore, () => new LoginViewModel(navigationStore)));
        }*/ 
    }
}
