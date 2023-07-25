using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    [Table("COURSES")]
    public class Course
    {
        public int CourseId { get; set; }
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

        public Course()
        {
            Groups = new List<Group>();
        }
    }   
}
