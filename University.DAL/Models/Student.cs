using System.ComponentModel.DataAnnotations.Schema;

namespace University.DAL.Models
{
    [Table("STUDENTS")]
    public class Student
    {
        public int StudentId { get; set; }
        [Index(IsUnique = true)]
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Group Group { get; set; }
    }
}
