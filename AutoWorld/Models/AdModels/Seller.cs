using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }
    }
}