using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Make
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

    }
}