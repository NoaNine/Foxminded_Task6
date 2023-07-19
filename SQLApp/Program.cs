using Microsoft.Extensions.Hosting;

namespace SQLApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(app =>
    {
        app.SetBasePath(Directory.GetCurrentDirectory());
        app.AddJsonFile("appsettings.json");
    })
    .ConfigureServices((_, services) =>
    {
        services.Configure<Settings>(_.Configuration.GetSection("Settings"));
        services.AddScoped(typeof(INumberGenerator), typeof(NumberGenerator));
        services.AddTransient(typeof(IUserInteractionReader), typeof(ConsoleReader));
        services.AddTransient(typeof(IUserInteractionWriter), typeof(ConsoleWriter));
        //services.AddSingleton(typeof(IGame), typeof(Game));
        services.AddSingleton(typeof(IGameNotification), typeof(GameCore));
    })
    .Build();
            var game = host.Services.GetService<IGameNotification>() ?? throw new ArgumentNullException("Game");

        }
    }
}