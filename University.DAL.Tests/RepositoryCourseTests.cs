namespace University.DAL.Tests;

[TestClass]
public class RepositoryCourseTests : SqliteConnection
{
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

    [TestMethod]
    public void Insert_WhenCalled_MoreData()
    {
        using var context = CreateContext();
        var repository = new Repository<Course>(context);
        var count = context.Courses.Count();
        repository.Insert(new Course { Name = "", Description = "" });
        context.SaveChanges();
        var result = context.Courses.Count();
        Assert.AreEqual(count + 1, result);
    }

    [TestMethod]
    public void Insert_WhenCalled_LessData()
    {
        using var context = CreateContext();
        var repository = new Repository<Course>(context);
        var count = context.Courses.Count();
        repository.Delete(context.Courses.Single(i => i.Id == 4));
        context.SaveChanges();
        var result = context.Courses.Count();
        Assert.AreEqual(count - 1, result);
    }
}