using University.DAL.Tests.Data;

namespace University.DAL.Tests;

[TestClass]
public class RepositoryCourseTests
{
    private readonly DbContextOptions<UniversityContext> _dbContextOptions;
    private readonly UniversityContext _universityContext;
    private readonly Repository<Course> _repositoryCourse;

    public RepositoryCourseTests()
    {
        _dbContextOptions = new DbContextOptionsBuilder<UniversityContext>()
            .UseInMemoryDatabase(databaseName: "UniversityDatabase")
            .Options;
        _universityContext = new UniversityContext(_dbContextOptions);
        _universityContext.Courses.AddRange(RepositoryCourseTestData.GetData());
        _universityContext.SaveChanges();
        _repositoryCourse = new Repository<Course>(_universityContext);
    }

    [TestMethod]
    public void GetById_WhenCalled_ReturnsCourseById()
    {
        var expected = new Course { Id = 2, Name = "Комп`ютерна інженерія", Description = "" };
        var course = _repositoryCourse.GetByID(2);
        Assert.AreEqual(expected.Name, course.Name);
    }

    [TestMethod]
    public void GetAll_WhenCalled_ReturnsAllCourses()
    {
        var expected = RepositoryCourseTestData.GetData();
        var course = _repositoryCourse.GetAll();
        Assert.AreEqual(expected.Count(), course.Count());
    }
}