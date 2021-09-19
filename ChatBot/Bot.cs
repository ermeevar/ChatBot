namespace ChatBot
{
    public class Bot
    {
        delegate void StartGuide();
        private delegate void EndGuide();

        StartGuide startGuide;
        EndGuide endGuide;

        public Bot()
        {
            startGuide = HelloMessage;
            startGuide += InformationMessage;
            startGuide += ChoiceMessage;

            
        }

        private void HelloMessage() => System.Console.WriteLine("Привет");
        private void InformationMessage() => System.Console.WriteLine(@"Это блог про ""честные"" выборы");
        private void ChoiceMessage() => System.Console.WriteLine("Что бы вы хотели узнать?");
        private void GratitudeMessage() => System.Console.WriteLine(@"Спасибо за участие, ваш голос очень ""важен""");
        private void ByeMessage() => System.Console.WriteLine("До новых встреч");

        public void PushStartMessages() => startGuide?.Invoke();
        public void PushEndMessages() => endGuide?.Invoke();
    }
}
