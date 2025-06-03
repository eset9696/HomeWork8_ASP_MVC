using HomeWork8_ASP_MVC.Services;
using HomeWork8_ASP_MVC.Services.Implementations;

namespace HomeWork8_ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<IGreetingService, GreetingService>();

            var app = builder.Build();



            app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
