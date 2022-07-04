using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public Make Make { get; set; }
        [Required]
        public Model Model { get; set; }
        [Required]
        public DateTime ManufacturedDate { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public Colour Colour { get; set; }
        public CarFeature CarFeature { get; set; }
        [Required]
        public EngineType EngineType { get; set; }
        [Required]
        public TransmissionType TransmissionType { get; set; }
        public int Power { get; set; }
        public EcoCategory EcoCategory { get; set; }
        [Required]
        public Category Category { get; set; }

    }
}
