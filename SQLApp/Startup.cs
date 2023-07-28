using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using University.DAL.Models;
using University.DAL.Repository;

namespace SQLApp
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddDbContext<UniversityContext>(o => o.UseSqlServer(_configuration.GetConnectionString("Data:ConnectionStrings:MSSQLConnection")));
            service.AddScoped<IRepository<Course>, Repository<Course>>();
            service.AddScoped<IRepository<Group>, Repository<Group>>();
            service.AddScoped<IRepository<Student>, Repository<Student>>();
        }
    }
}
