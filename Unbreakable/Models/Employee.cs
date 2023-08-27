using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Unbreakable.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
        
        [MaxLength(30)]
        [DisplayName("Address")]
        public string Address { get; set; }
        
        [Range(1, 10)]
        public long PhoneNumber { get; set; }
    }
}
