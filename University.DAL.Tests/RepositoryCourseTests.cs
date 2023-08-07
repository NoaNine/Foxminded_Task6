namespace University.DAL.Tests;

[TestClass]
public class RepositoryCourseTests
{
    private readonly DbConnection _connection;
    private readonly DbContextOptions<UniversityContext> _contextOptions;

    public RepositoryCourseTests()
    {
        _connection = new SqliteConnection("Filename=:memory:");
        _connection.Open();
        _contextOptions = new DbContextOptionsBuilder<UniversityContext>()
            .UseSqlite(_connection)
            .Options;
        using var context = new UniversityContext(_contextOptions);
        context.Database.EnsureCreated();
        context.Courses.UpdateRange(RepositoryCourseTestData.GetData());
        context.SaveChanges();
    }

    public UniversityContext CreateContext() => new UniversityContext(_contextOptions);

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
        Assert.AreEqual(4, result.Count());
    }
}