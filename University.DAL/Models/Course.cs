using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    [Table("COURSES")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }   
}
