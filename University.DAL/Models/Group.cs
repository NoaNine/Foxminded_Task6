using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    [Table("GROUPS")]
    public class Group
    {
        public int GroupId { get; set; }
        [Index(IsUnique = true)]
        public int CourseId { get; set; }
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}
