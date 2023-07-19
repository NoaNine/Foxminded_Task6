using Microsoft.Extensions.Configuration;
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
                    //services.Configure<Settings>(_.Configuration.GetSection("Settings"));
                    //services.AddScoped(typeof(I), typeof());
                    //services.AddTransient(typeof(I), typeof());
                    //services.AddSingleton(typeof(I), typeof());
                })
                .Build();
        }
    }
}