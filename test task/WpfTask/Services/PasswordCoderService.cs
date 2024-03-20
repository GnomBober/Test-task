
using System.Text;

namespace WpfTask.Services
{
    internal class PasswordCoderService
    {
        public static string PasswordCoder(string password)
        {
            string salt = "abc9";
            string coded;
            coded = $"{salt}" + $"{password}" + $"{salt}";

            byte[] b = Encoding.ASCII.GetBytes(password);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var symb in b)
            {
                stringBuilder.Append(symb.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
