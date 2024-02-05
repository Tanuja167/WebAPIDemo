using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]

        public string? Department { get; set; }
        [Required]

        public int Salary { get; set; }

    }
}
