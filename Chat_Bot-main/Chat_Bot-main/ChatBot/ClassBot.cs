/// @author Kyvukin N.D
/// Реализация чат-бота

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ChatBot
{   
    /// Чат-бот может отвечать на привет/ выдавать текущее время, которое в ОС, дату, умеет слаживать и вычитать, выдавать ip-address
    public class Bot
    {
        //ChatBotHistory для хранения истории сообщение и взаимодествия чат-бота
        public List<string> ChatBotHistory = new List<string>();
        ///регулярные выражения..
        /// IgnoreCase игнорирует регист символов при сопоставлении
        /// * означает ноль или более повторений
        public static Regex regexHello = new Regex(@"Ха*й|приве*т|здарова", RegexOptions.IgnoreCase);
        public static Regex regexTime = new Regex(@"время$|час$", RegexOptions.IgnoreCase);
        public static Regex regexDate = new Regex(@"число$|дата$", RegexOptions.IgnoreCase);
        public static Regex regexHowAreYou = new Regex(@"как дела?", RegexOptions.IgnoreCase);
        public static Regex regexSum = new Regex(@"Сложи", RegexOptions.IgnoreCase);
        public static Regex regexSub = new Regex(@"Вычти", RegexOptions.IgnoreCase);
        public static Regex regexIP = new Regex(@"ip$|айпи$", RegexOptions.IgnoreCase);
        public static Regex regexInstuction = new Regex("что ты умеешь$|инструкция", RegexOptions.IgnoreCase);


        //ссылка,по которой происходит поиск айпим адреса
        string url = "https://hidemy.name/ru/what-is-my-ip/";

        //todo сделать так, чтобы класс бота был независим от форм
        //имя пользователя
        string userName = FormLogin.userName;

        

        ///вывод запросов пользователя и ответов бота 
        public string BotSay(string bot)
        {
            return "[" + DateTime.Now.ToString("HH:mm") + "] " + "ArutaBob" + ": " + bot + "\r" + "\n";
        }

        public string UserQuest(string quest)
        {
            return "[" + DateTime.Now.ToString("HH:mm") + "] " + FormLogin.userName + ": " + quest + "\r" + "\n";
        }

        Random rand = new Random();

        ///привет от бота
        public string SetHelloBot()
        {
            // Random rand = new Random();
            string[] mas = { "Привет", "Hi","Q","Ку" };
            int mas1 = rand.Next(mas.Length);

            return mas[mas1] + " " + userName;
        }
        ///ответ на вопрос - как дела
        public string SetHowBot()
        {
            //Random rand = new Random();
            string[] mas = { "просто замечательно", "лучше не бывает" };
            int mas1 = rand.Next(mas.Length);

            return mas[mas1];


        }

        ///получение ip 
        /// https://upread.ru/art.php?id=84
        public string SiteIP()
        {
            //WebClient класс предоставляет общие методы для отправки или 
            //    получения данных из любого локального, интрасети или 
            //    интернет - ресурса, определяемого универсальным кодом ресурса(URI).
            // создаем ссылку на объект WebClient
            using (WebClient client = new WebClient())
            {
                //задается кодировка скачиваемой страницы
                client.Encoding = System.Text.Encoding.UTF8;
                //включаем поддержку защищенного протокола(https)
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                // получаем данные страницы
                var htmlData = client.DownloadData(url);
                // и конвертим их в string, учитывая кодировку
                string htmlCode = Encoding.UTF8.GetString(htmlData);

                //с помощью регулярных выражений убираем все до вхождения подстроки 


                // type - string[] - массив строк
                //Split- делит код напополам
                var parts1 = Regex.Split(htmlCode, "<div class=ip_block><p>Ваш IP-адрес</p><div class=ip>");
                //получаем второй элемент массива(сплит по коду пробела)
                var parts2 = Regex.Split(parts1[1], " ");

                //заменяем строки по указанному регулярному выражению на пустую строку
                string numberPosition = (Regex.Replace(parts2[0], @"</div>|<form", ""));
                //  @ - заставляет понимать строку без специальных символов, т.е буквально
                return "ваш ip: " + numberPosition;
            }
        }


        ///проверка запросов для получения ответа
        public string Answer(string b)
        {
            if (regexHello.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.SetHelloBot());
            }
            if (regexDate.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.DateBot());
            }
            if (regexTime.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.TimeBot());
            }
            if (regexSum.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.BotSum(b));
            }
            if (regexSub.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.BotSub(b));
            }
            if(regexHowAreYou.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                 + this.BotSay(this.SetHowBot());
            }
           
            if (regexIP.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                + this.BotSay(this.SiteIP());
            }
            if (regexInstuction.IsMatch(b))
            {
                return this.UserQuest(b) + "\r"
                               + this.BotSay(this.BotInstruction());
            }


            else
            {
                return this.UserQuest(b) + "\r" + "[" + DateTime.Now.ToString("HH:mm") + "] " + "ArutaBob" + ": "
                    + "К сожалению, я не понимаю, что вы имеете ввиду" + "\r" + "\n";
            }
        }

        ///инструкция
        public string BotInstruction()
        {
            return "\r" + "\n" + "Я умею выполнять следующие действия: " + "\r" + "\n"
            + "Отвечать на приветствие разными вариантами " + "\r" + "\n"
            + "Отвечать на вопрос 'Как дела?'" + "\r" + "\n"
            + "Показывать дату и время " + "\r" + "\n"
            + "Складывать числа 'a и b' = c" + "\r" + "\n"
            + "Вычитать числа 'a из b' = c" + "\r" + "\n"
            + "Выдать ваш ip" + "\r" + "\n"
            + "Приятного общения";
        }

        ///запрос время
        public string TimeBot()
        {
            return DateTime.Now.ToString("T");
        }
        ///запрос дата
        public string DateBot()
        {
            return DateTime.Now.ToString("D");
        }


        ///запрос сложение
        public string BotSum(string quest)
        {

            quest = quest.Replace(" ", "");
            quest = quest.Substring(quest.LastIndexOf('ж') + 2); 
            string[] words = quest.Split(new char[] { 'и' }, StringSplitOptions.RemoveEmptyEntries);
            int a = Convert.ToInt32(words[0]);
            int b = Convert.ToInt32(words[1]);
            return (a + b).ToString();

        }
        /// запрос вычитание
        public string BotSub(string quest)
        {
            // Удаление всех пробелов
            quest = quest.Replace(" ", "");

            // Извлечение подстроки после последней буквы 'т' (предположительно, часть слова "вычти")
            quest = quest.Substring(quest.LastIndexOf('т') + 2);

            // Разделение строки по символам 'и' и 'з' (например, в выражении "вычти 7 из 10")
            string[] words = quest.Split(new char[] { 'и', 'з' }, StringSplitOptions.RemoveEmptyEntries);

            // Преобразование чисел из строк в целые числа
            int a = Convert.ToInt32(words[0]);
            int b = Convert.ToInt32(words[1]);

            // Обычное вычитание: b - a, без изменения знаков
            return (a - b).ToString();
        }
    }

}


