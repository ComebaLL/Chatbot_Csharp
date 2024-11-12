/// @author Kyvukin N.D
/// Чат-бот
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Сначала запускаем FormLogin для ввода userName
            FormLogin loginForm = new FormLogin();
            Application.Run(loginForm);

            // Если пользователь ввел имя и форма не закрыта, то продолжаем запускать FormBot
            if (!string.IsNullOrEmpty(FormLogin.userName))
            {
                Application.Run(new FormBot(FormLogin.userName));
            }
        }
    }
}
