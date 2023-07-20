using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.DAL.Models;
using University.DAL.Repository;

namespace SQLApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(app =>
                { 
                    app.SetBasePath(Directory.GetCurrentDirectory());
                    app.AddJsonFile("appsettings.json");
                    app.AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
                    app.AddEnvironmentVariables();
                })
                .ConfigureServices((_, services) =>
                {
                    //services.Configure<Settings>(_.Configuration.GetSection("Settings"));
                    //services.AddDbContext<UniversityContext>();
                    services.AddScoped<IRepository<Course>, Repository<Course>>();
                    services.AddScoped<IRepository<Group>, Repository<Group>>();
                    services.AddScoped<IRepository<Student>, Repository<Student>>();

                })
                .Build();
        }
    }
}