using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud2.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(80)")]
        public string Name { get; set; } = string.Empty;
        public string Mobile { get; set; }  
        public int Age { get; set; }
    }
}
