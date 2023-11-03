using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Crud2.Models
{
    public class Car : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Model {  get; set; }
        [Required]
        [MaxLength(20)]
        public string Brand { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
