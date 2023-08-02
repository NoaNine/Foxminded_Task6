namespace University.DAL.Models;

public class Group : Model
{
    public string Name { get; set; }
    public Course Course { get; set; }
    public ICollection<Student> Students { get; set; }
}
