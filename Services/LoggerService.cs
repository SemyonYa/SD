namespace SD2.Services
{
    public class LoggerService
    {
        private int counter;
        public LoggerService()
        {
            counter = 0;
        }
        public void Write(string message)
        {
            // Логгируует действия пользователя
            Console.WriteLine(message);
            counter++;
        }
    }
}
