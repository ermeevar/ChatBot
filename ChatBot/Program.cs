using System;
using System.Threading;

namespace ChatBot
{
    class Program
    {
        delegate T AnyDelegate<T, F>(F prm);

        static void Main(string[] args)
        {
            Bot bot = new Bot();

            #region Putin
            //Bot putinBot = new Bot();

            //putinBot.PushStartMessages();

            //Thread.Sleep(5000);

            //putinBot.PushEndMessages();
            #endregion

            AnyDelegate<bool, string> anyDelegate = IsStringEmpty;
            
        }

        public static bool IsStringEmpty(string prm) => String.IsNullOrEmpty(prm);
    }

    class B : MulticastDelegate { }
}
