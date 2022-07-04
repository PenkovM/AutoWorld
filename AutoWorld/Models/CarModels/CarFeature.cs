using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class CarFeature
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }

  
    }
}