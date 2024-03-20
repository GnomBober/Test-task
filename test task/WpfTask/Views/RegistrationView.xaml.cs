using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfTask.ViewModels;

namespace WpfTask.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Window
    {
        RegistrationViewModel registrationViewModel = new RegistrationViewModel();
        public RegistrationView()
        {
            this.DataContext = registrationViewModel;
            InitializeComponent();
        }

        private void logField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
