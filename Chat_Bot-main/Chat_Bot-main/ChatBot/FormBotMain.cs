/// @author Maltseva K.V.
/// Реализация чат-бота


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatBot
{
    public partial class FormBot : Form
    { ///ссылкa на обЪъект
        public Bot bot = new Bot();

       // List<string> ChatBotHistory = new List<string>();
        public FormBot()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.image_back;
            KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormBot_KeyEnter);


        }
        ///Горячая клавиша enter
        private void FormBot_KeyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Send.PerformClick();
            }
        }
        ///отправить запрос
        private void button_Send_Click(object sender, EventArgs e)
        {
            //bot.BotCheckReg(textBox_Question.Text);

            //textBox_Answer.Text += bot.Answer(textBox_Question.Text, bot);
            ////bot.AddHistory(bot.Answer(textBox_Question.Text, bot));
            ////textBox_Answer.Text += bot.Watch(textBox_Answer.Text);

            string answer = bot.Answer(textBox_Question.Text);
            string date = DateTime.Now.ToString("D");
            bot.ChatBotHistory.Add($"История чата от " + date + "\r\n"+answer); // Добавляем ответ в список chatHistory объекта chat

            textBox_Answer.Text += answer;

            //автоскролинг
            textBox_Answer.SelectionStart = textBox_Answer.Text.Length;
            textBox_Answer.ScrollToCaret();

            textBox_Question.Clear();
        }

        ///справка об авторе
        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("@author Maltseva K.V.");
        }
        ///сохранение чата в фаил
        private void сохранитьИсториюЧатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bot.SaveHistory(textBox_Answer.Text);

            
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt"; // Фильтр для типа файлов
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл 
                    {
                        //string date = DateTime.Now.ToString("D");

                        //string text = a;
                        // ChatBotHistory.push_front($"История чата от " + date + "\r\n");
                       // bot.ChatBotHistory.Add($"История чата от " + date + "\r\n" );
                        //File.WriteAllText(saveFileDialog.FileName, all); // сохранение текста в файл по выбранному пути
                        File.WriteAllLines(saveFileDialog.FileName, bot.ChatBotHistory);
                    }
                }
            
            //string path = "..ChatBot\\content.txt"; // путь к файлу
            // string text = textBox_Answer.Text; // текст из TextEdit
            //File.WriteAllText(path, text); // сохранение текста в файл



            //using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            //{
            //    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt"; // Фильтр для типа файлов
            //    if (saveFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл 
            //    {
            //        /*string date = DateTime.Now.ToString();*/
            //        string text = textBox_Answer.Text;
            //        string content = $"{date}\n{text}";
            //        File.WriteAllText(saveFileDialog.FileName, content); // сохранение текста в файл по выбранному пути
            //    }
        }
       
        ///загрузка чата из фаила
        private void загрузитьЧатИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // bot.LoadHistory(textBox_Answer.Text);
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Фильтр для типа файлов
                    if (openFileDialog.ShowDialog() == DialogResult.OK) // Если пользователь выбрал файл 
                    {
                        string text = File.ReadAllText(openFileDialog.FileName); // чтение текста из выбранного файла
                        textBox_Answer.Text = text; // загрузка текста в TextEdit
                    }
                }
            }
        }


        ///очистить чат
        private void очиститьЧатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = string.Empty;
        }

        ///инструкция
        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bot.BotInstruction());
        }
    }
}