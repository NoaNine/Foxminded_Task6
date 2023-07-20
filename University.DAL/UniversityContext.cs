using System.Data.Entity;
using University.DAL.Models;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }    
    public DbSet<Course> Courses { get; set; }
    
    public UniversityContext() : base("connectionMSSQL")
    {

    }
}