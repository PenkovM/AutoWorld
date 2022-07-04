using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
    }
}