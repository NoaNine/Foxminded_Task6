using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    [Table("GROUPS")]
    public class Group
    {
        [Key]
        [Index(IsUnique = true)]
        public int GroupId { get; set; }
        [Index(IsUnique = true)]
        public int CourseId { get; set; }
        public string Name { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
