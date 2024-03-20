using WpfTask.Services;
using System.Windows;
using WpfTask.Views;

namespace WpfTask.Services
{
    internal class DbInterractionService
    {
        public bool CheckRegistration(string checkLogin)
        {
            using (DbConnectionService db = new DbConnectionService())
            {
                return
                db.Users.Any(p => p.login == checkLogin);
            }
        }
        public User? GetUser(string login)
        {
            using (DbConnectionService db = new DbConnectionService())
            {
                return
                db.Users.FirstOrDefault(p => p.login == login);
            }
        }
        public void RegisterUser(string login, string password, string repPassword)
        {
            if (password != repPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            using (DbConnectionService db = new DbConnectionService())
            {
                if (!CheckRegistration(login))
                {
                    User user = new User();
                    user.login = login;
                    user.password = PasswordCoderService.PasswordCoder(password);
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь добавлен");
                    return;
                }
                MessageBox.Show("Пользователь уже сущетсвует");
            }
        }
        public void LoginUser(string login, string password)
        {
            if (login == "admin" && password == "admin")
            {
                AdminView adminWindow = new AdminView();
                adminWindow.Show();
                return;
            }
            else
            {
                using (DbConnectionService db = new DbConnectionService())
                {
                    password = PasswordCoderService.PasswordCoder(password);
                    User user = GetUser(login);
                    if (user is null)
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        return;
                    }
                    if (user.password == password)
                    {
                        UserView window = new UserView();
                        window.Show();
                        return;
                    }
                }
            }
        }
    }
}
