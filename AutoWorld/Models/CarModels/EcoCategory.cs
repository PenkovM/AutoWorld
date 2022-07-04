using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public enum EcoCategory
    {
        Eco1=1,
        Eco2=2,
        Eco3=3,
        Eco4=4,
        Eco5=5,
        Eco6=6,
        [Display(Name="Eco6+")]
        Eco6plus=7
    }
}