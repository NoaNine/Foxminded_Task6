namespace University.DAL.Tests;

public abstract class SqliteConnection
{
    private readonly DbConnection _connection;
    private readonly DbContextOptions<UniversityContext> _contextOptions;

    public SqliteConnection()
    {
        _connection = new Microsoft.Data.Sqlite.SqliteConnection("Filename=:memory:");
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
}
