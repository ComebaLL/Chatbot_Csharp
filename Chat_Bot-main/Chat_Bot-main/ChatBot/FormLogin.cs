/// @author Maltseva K.V.
/// Реализация чат-бота

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormLogin_KeyDown);
        }

        public static string userName { get; set; }

        ///Горячая клавиша enter
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                buttonLogin.PerformClick();
            }
        }

        ///обработчик события - войти
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                
                labelError.Text = "Вы забыли ввести имя";
            }
            else

            {
                userName = textBoxLogin.Text;
                Form FormBot = new FormBot();
                Close();
                FormBot.Show();
            }
        }


    }
}
