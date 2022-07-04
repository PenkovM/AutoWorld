using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public enum TransmissionType
    {
        Manual = 1,
        Automatic=2,
        [Display(Name = "Semi-Automatic")]
        SemiAutomatic=3

    }
}