using WpfTask.Stores;
using System.Windows.Input;
using WpfTask.Commands;
using WpfTask.Services;
using WpfTask.Views;

namespace WpfTask.ViewModels
{
    internal class AccountViewModel : ViewModelBase
    {
        public string Name => "SingletonSean";

        public ICommand NavigateHomeCommand { get;}

        //private RelayCommand loginCommand;
        //public ICommand LoginCommand => loginCommand ??= new RelayCommand(Login);

        private void Login(object commandParameter)
        {
            UserView view = new UserView();
            view.Show();
        }
        /*public AccountViewModel(NavigationStore navigationStore)
        {
             NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(
                 navigationStore, () => new HomeViewModel(navigationStore)));
        }*/ 
    }
}
