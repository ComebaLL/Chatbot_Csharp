/// @author Kyvukin N.D
/// Тест для чатбота
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatBot;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace ChatBot.Tests
{
    [TestClass()]
    public class BotTests
    {
        Bot bot = new Bot();
       

    

        [TestMethod()]
        public void SetHelloBotTest()
        {
           // string quest = "привет";
          
            var bot_ans = bot.BotSay(bot.SetHelloBot()); // Ответ бота

            Assert.IsTrue(bot_ans.Contains("Привет") ||
               bot_ans.Contains("Q") ||
               bot_ans.Contains("Ку")
               );
        } 

        [TestMethod()]
        public void SetHowBotTest()
        {
            //string quest = "как дела";

         
            var bot_ans = bot.BotSay(bot.SetHowBot()); // Ответ бота

            Assert.IsTrue(bot_ans.Contains("лучше не бывает") ||
               bot_ans.Contains("просто замечательно");

        }

        [TestMethod()]
        public void SiteIPTest()
        {
                string quest = "айпи";

                Assert.AreEqual(bot.UserQuest(quest) + "\r" + bot.BotSay(bot.SiteIP()), bot.Answer(quest));
   
        }


        [TestMethod()]
        public void BotInstructionTest()
        {
            string quest = "что ты умеешь";
            Assert.AreEqual(bot.UserQuest(quest) + "\r"  + bot.BotSay(bot.BotInstruction()), bot.Answer(quest));
        }

        [TestMethod()]
        public void TimeBotTest()
        {

            string quest = "сколько сейчас время";

            Assert.AreEqual(bot.UserQuest(quest) + "\r"  + bot.BotSay(bot.TimeBot()), bot.Answer(quest));
        }
       

        [TestMethod()]
        public void DateBotTest()
        {
            string quest = "какая сегодня дата";

            Assert.AreEqual(bot.UserQuest(quest) + "\r" + bot.BotSay(bot.DateBot()), bot.Answer(quest));
        }

        [TestMethod()]
        public void BotSumTest()
        {
            string quest = "Сложи 120 и 80";
            string quest2 = "Сложи 71 и 37";
            string quest3 = "Сложи 1234 и 5678";
            Assert.AreEqual("200", bot.BotSum(quest));
            Assert.AreEqual("108", bot.BotSum(quest2));
            Assert.AreEqual("6912", bot.BotSum(quest3));
        }

        [TestMethod()]
        public void BotSubTest()
        {

            string quest = "Вычти 1 из 0";
            string quest2 = "Вычти 45 из 234";
            string quest3 = "Вычти 123 из 321";
            Assert.AreEqual("-1", bot.BotSub(quest));
            Assert.AreEqual("189", bot.BotSub(quest2));
            Assert.AreEqual("198", bot.BotSub(quest3));
        }
    }
}