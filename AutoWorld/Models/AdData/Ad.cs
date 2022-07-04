using System.ComponentModel.DataAnnotations;

namespace AutoWorld.Models
{
    public class Ad
    {
       public int Id { get; set; }
       public Car Car { get; set; }
       public string ImageUrl { get; set; }
       public string AdditionalInfo { get; set; }
       public Seller Seller { get; set; }
    }
}
