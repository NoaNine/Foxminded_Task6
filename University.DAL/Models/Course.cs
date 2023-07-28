namespace University.DAL.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }   
}
