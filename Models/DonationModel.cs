using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class DonationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float? Value { get; set; }
        [Required]
        public CCDonationEnum CCDonation { get; set; }
        public string? Description { get; set; }
    }
}
