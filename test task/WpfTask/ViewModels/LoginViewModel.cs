using System.Windows.Input;
using WpfTask.Commands;
using WpfTask.Stores;
using WpfTask.Services;
using WpfTask.Views;

namespace WpfTask.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(param => OnLogin());
                }
                return _loginCommand;
            }
        }
        DbInterractionService dbInterractionService = new DbInterractionService();
        public void OnLogin()
        {
            dbInterractionService.LoginUser(UserName, Password);
        }

        private RelayCommand openRegistrationCommand;
        public ICommand OpenRegistrationCommand => openRegistrationCommand ??= new RelayCommand(OpenRegistration);

        private void OpenRegistration(object commandParameter)
        {
            RegistrationView registrationView = new RegistrationView();
            registrationView.Show();
        }
    }
}
