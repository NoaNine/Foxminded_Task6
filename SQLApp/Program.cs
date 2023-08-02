using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using University.DAL;
using University.DAL.Extensions;
using University.DAL.Models;
using University.DAL.Repository;

namespace SQLApp;

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
            .ConfigureServices((context, services) =>
            {
                IConfiguration configuration = context.Configuration;
                services.AddDbContext<UniversityContext>(o => o.UseSqlServer(configuration.GetConnectionString("UniversityDatabase")));
                services.AddDataDependencies();
            })
            .Build();
        var repository = host.Services.GetService<IRepository<Course>>();
        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item.Name);
        }
    }
}