using System;
using System.Threading;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            bot.dateStart += PrintStartDate;
            bot.dateStart += PrintEnvironment;

            bot.StartDialog();
        }

        public static void PrintStartDate() =>
            Console.WriteLine($"Дата запуска бота: {DateTime.Now}");

        public static void PrintEnvironment() =>
            Console.WriteLine($"Среда: {Environment.CurrentDirectory}");
    }
}
