namespace University.DAL.Tests.Data;

public class RepositoryCourseTestData
{
    public static Course[] GetData()
    {
        return new Course[]
        {
            new Course { Id = 1, Name = "Прикладна математика", Description = "" },
            new Course { Id = 2, Name = "Комп`ютерна інженерія", Description = "" },
            new Course { Id = 3, Name = "Електроніка та електромеханіка ", Description = "" },
            new Course { Id = 4, Name = "Юридичне право", Description = "" }
        };
    }
}
