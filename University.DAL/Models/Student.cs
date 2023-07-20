using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    [Table("STUDENTS")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Index(IsUnique = true)]
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
