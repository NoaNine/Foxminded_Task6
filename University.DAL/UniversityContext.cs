using Microsoft.EntityFrameworkCore;
using University.DAL;
using University.DAL.Models;

public class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Course> Courses { get; set; }

    public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(c =>
        {
            c.ToTable("Courses")
            .HasMany(c => c.Groups)
            .WithOne(g => g.Course)
            .HasForeignKey(g => g.CourseId)
            .HasPrincipalKey(c => c.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

            c.HasIndex(c => c.Name)
            .IsUnique();

            c.Property(p => p.CourseId)
            .UseIdentityColumn(1, 1);
        });

        modelBuilder.Entity<Group>(g =>
        {
            g.ToTable("Groups")
            .HasMany(g => g.Students)
            .WithOne(s => s.Group)
            .HasForeignKey(s => s.GroupId)
            .HasPrincipalKey(g => g.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

            g.HasIndex(c => c.Name)
            .IsUnique();
        });

        modelBuilder.Entity<Student>(s =>
        {
            s.ToTable("Students")
            .HasKey(s => s.StudentId);
        });

        modelBuilder.Seed();
    }
}