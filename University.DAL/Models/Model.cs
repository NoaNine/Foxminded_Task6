using System.ComponentModel.DataAnnotations;

namespace University.DAL.Models;

public abstract class Model
{
    [Key]
    public int Id { get; set; }
}
