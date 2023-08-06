namespace University.DAL.Tests;

[TestClass]
public class RepositoryCourseTests1
{
    private readonly DbConnection _connection;
    private readonly DbContextOptions<UniversityContext> _contextOptions;

    public RepositoryCourseTests1()
    {
        _connection = new SqliteConnection("Filename=:memory:");
        _connection.Open();
        _contextOptions = new DbContextOptionsBuilder<UniversityContext>()
            .UseSqlite(_connection)
            .Options;
        using var context = new UniversityContext(_contextOptions);

        if (context.Database.EnsureCreated())
        {
            using var viewCommand = context.Database.GetDbConnection().CreateCommand();
            viewCommand.CommandText = @"
CREATE VIEW AllResources AS
SELECT Id
FROM Courses;";
            viewCommand.ExecuteNonQuery();
        }
        context.Courses.AddRange(
            new Course { Id = 1, Name = "Прикладна математика", Description = "" },
            new Course { Id = 2, Name = "Комп`ютерна інженерія", Description = "" }
            );
        context.SaveChanges();
    }

    UniversityContext CreateContext() => new UniversityContext(_contextOptions);

    public void Dispose() => _connection.Dispose();

    [TestMethod]
    public void GetById_WhenCalled_ReturnsCourseById()
    {
        using var context = CreateContext();
        var repository = new Repository<Course>(context);

        var result = repository.GetByID(1);
        Assert.AreEqual(1, result.Id);
    }

    [TestMethod]
    public void GetAll_WhenCalled_ReturnsAllCourses()
    {
        using var context = CreateContext();
        var repository = new Repository<Course>(context);

        var result = repository.GetAll();
        Assert.AreEqual(2, result.Count());
    }
}