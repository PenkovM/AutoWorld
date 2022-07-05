using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Ad
    {
        public int Id { get; set; }
        [Required]
        public Car Car { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [StringLength(2000)]
        public string AdditionalInfo { get; set; }
        [Required]
        public Seller Seller { get; set; }
    }
}
