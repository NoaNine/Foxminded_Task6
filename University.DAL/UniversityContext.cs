using Microsoft.EntityFrameworkCore;
using University.DAL.Models;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }    
    public DbSet<Course> Courses { get; set; }
    
    public UniversityContext(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=University;Trusted_Connection=True;");
    }

    public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>()
        .ToTable("Courses")
        .HasMany(c => c.Groups)
        .WithOne(g => g.Course)
        .HasForeignKey(g => g.CourseId)
            .HasPrincipalKey(c => c.CourseId);
        modelBuilder.Entity<Group>()
            .ToTable("Groups")
            .HasMany(g => g.Students)
            .WithOne(s => s.Group)
            .HasForeignKey(s => s.GroupId)
            .HasPrincipalKey(g => g.GroupId);
        modelBuilder.Entity<Student>()
            .ToTable("Students")
            .HasKey(s => s.StudentId);
    }
}