using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_project.EMS.Domain.Entities;

public class Employee
{   [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }
   [Column(TypeName = "decimal(18, 2)")]
    public decimal Salary { get; set; }

    public string Department { get; set; }

    public string? ImagePath { get; set; }

    public DateTime CreatedAt { get; set; }
}
