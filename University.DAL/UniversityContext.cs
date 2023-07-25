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

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasKey(s => s.StudentId);
        modelBuilder.Entity<Group>()
            .HasMany(g => g.Students)
            .WithRequired(s => s.Group)
            .HasForeignKey(s => s.GroupId)
            .WillCascadeOnDelete();
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Groups)
            .WithRequired(g => g.Course)
            .HasForeignKey(g => g.CourseId)
            .WillCascadeOnDelete();
    }
}