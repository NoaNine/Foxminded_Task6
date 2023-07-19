using System.Collections.Generic;
using System.Data.Entity;
using University.DAL;
using University.Models;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }    
    public DbSet<Course> Courses { get; set; }
    
    public UniversityContext() : base("connectionMSSQL")
    {

    }
}