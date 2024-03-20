using System.Windows.Input;
using WpfTask.Commands;
using WpfTask.Services;

namespace WpfTask.ViewModels
{
    internal class RegistrationViewModel : ViewModelBase
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

        private string _repeatedPassword;
        public string RepeatedPassword
        {
            get
            {
                return _repeatedPassword;
            }
            set
            {
                _repeatedPassword = value;
                OnPropertyChanged(nameof(RepeatedPassword));
            }
        }

        private ICommand _registrationCommand;
        public ICommand RegistrationCommand
        {
            get
            {
                if (_registrationCommand == null)
                {
                    _registrationCommand = new RelayCommand(param => OnRegistration());
                }
                return _registrationCommand;
            }
        }
        DbInterractionService dbInterractionService = new DbInterractionService();
        public void OnRegistration()
        {
            dbInterractionService.RegisterUser(UserName, Password, RepeatedPassword);
        }
    }
}
