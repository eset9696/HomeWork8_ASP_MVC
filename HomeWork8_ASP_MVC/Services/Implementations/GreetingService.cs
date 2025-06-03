namespace HomeWork8_ASP_MVC.Services.Implementations
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 0 && hour < 6) 
            {
                return "Доброй ночи!";
            }
            if (hour >= 6 && hour < 12)
            {
                return "Доброе утро!";
            }
            if (hour >= 12 && hour < 18)
            {
                return "Добрый день!";
            }
            return "Добрый вечер!";
        }
    }
}
