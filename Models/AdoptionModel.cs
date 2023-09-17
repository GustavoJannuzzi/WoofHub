using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class AdoptionModel
    {
        [Key]
        public int Id { get; set; }
        public required ClientModel Client { get; set; }
        public required AnimalModel Animal { get; set; }
        public SituationEnum Situation { get; set; }
        public DateOnly Date { get; set; }
    }
}