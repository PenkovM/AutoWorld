using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Car
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public int Mileage { get; set; }
        public Colour Colour { get; set; }
        public CarFeature CarFeature { get; set; }
        public EngineType EngineType { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public int Power { get; set; }
        public EcoCategory EcoCategory { get; set; }
        public Category Category { get; set; }

    }
}
