using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace test_task
{
    internal class Model
    {
        public bool CheckRegistration(string checkLogin)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return
                db.Users.Any(p => p.login == checkLogin);
            }
        }
        public User? GetUser(string login)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return
                db.Users.FirstOrDefault(p => p.login == login);
            }
        }
        public string PasswordCoder(string password)
        {
            string salt = "abc9";
            string coded;
            coded = $"{salt}" + $"{password}" + $"{salt}";

            byte[] b = Encoding.ASCII.GetBytes(password);

            StringBuilder stringBuilder = new StringBuilder();
            foreach(var symb in b)
            {
                stringBuilder.Append(symb.ToString());
            }
            return stringBuilder.ToString();
        }
        public void RegisterUser(string login, string password, string repPassword)
        {
            if (password != repPassword)
            {
                MessageBox.Show("Пароли не совпадают");
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                if (!CheckRegistration(login))
                {
                    User user = new User();
                    user.login = login;
                    user.password = PasswordCoder(password);
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
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                return;
            }
            else
            {               
                using (ApplicationContext db = new ApplicationContext())
                {
                    password = PasswordCoder(password);
                    User user = GetUser(login);
                    if (user is null)
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        return;
                    }
                    if (user.password == password) 
                    {
                        Window1 window = new Window1();
                        window.Show();
                        return;
                    }
                }
            }
        }
    }
}
