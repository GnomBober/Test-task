using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace test_task
{
    internal class ViewModel : INotifyPropertyChanged
    {
        Model model = new Model();
        public string _regLogin {  get; set; }
        public string _regPassword { get; set; }
        public string _regRepPassword { get; set; }
        public string _logLogin { get; set; }
        public string _logPassword { get; set; }

        public string RegLogin
        {
            get { return _regLogin; }
            set
            {
                if (_regLogin != value)
                {
                    _regLogin = value;
                    OnPropertyChanged(nameof(RegLogin));
                }
            }
        }

        public string RegPassword
        {
            get { return _regPassword; }
            set
            {
                if (_regPassword != value)
                {
                    _regPassword = value;
                    OnPropertyChanged(nameof(RegPassword));
                }
            }
        }
        public string RegRepPassword
        {
            get { return _regRepPassword; }
            set
            {
                if (_regRepPassword != value)
                {
                    _regRepPassword = value;
                    OnPropertyChanged(nameof(RegRepPassword));
                }
            }
        }
        public string LogLogin
        {
            get { return _logLogin; }
            set
            {
                if (_logLogin != value)
                {
                    _logLogin = value;
                    OnPropertyChanged(nameof(LogLogin));
                }
            }
        }
        public string LogPassword
        {
            get { return _logPassword; }
            set
            {
                if (_logPassword != value)
                {
                    _logPassword = value;
                    OnPropertyChanged(nameof(LogPassword));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void OnRegistration()
        {
            model.RegisterUser(RegLogin, RegPassword, RegRepPassword);
        }
        public void OnLogin()
        {
            model.LoginUser(LogLogin,LogPassword);
        }
    }
}
