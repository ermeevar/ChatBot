namespace ChatBot
{
    public class Bot
    {
        public delegate void StartGuide();
        StartGuide startGuide;
        public event StartGuide dateStart;

        public Bot()
        {
            startGuide = HelloMessage;
            startGuide += InformationMessage;
            startGuide += ChoiceMessage;
        }

        public void StartDialog()
        {
            startGuide?.Invoke();
            dateStart?.Invoke();
        }

        private void HelloMessage() => System.Console.WriteLine("Привет");
        private void InformationMessage() => System.Console.WriteLine(@"Это блог про ""честные"" выборы");
        private void ChoiceMessage() => System.Console.WriteLine("Что бы вы хотели узнать?");
    }
}
