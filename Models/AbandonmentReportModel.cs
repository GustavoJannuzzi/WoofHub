using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class AbandonmentReport
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateOnly? Date { get; set; }
        [Required]
        public required AdressModel AbandonmentAdress { get; set; }
        public string? Description { get; set; }
    }
}
