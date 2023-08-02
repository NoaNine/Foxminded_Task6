namespace University.DAL.Models;

public class Student : Model
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Group Group { get; set; }
}
