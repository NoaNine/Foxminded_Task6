using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    [Table("STUDENTS")]
    public class Student
    {
        [Index(IsUnique = true)]
        public int StudentId { get; set; }
        [Index(IsUnique = true)]
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
