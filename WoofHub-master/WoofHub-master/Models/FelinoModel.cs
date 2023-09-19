using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class FelinoModel
    {
        [Key]
        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public int Age { get; set; }
        public string? Description { get; set; }
        public required SituationEnum Situation { get; set; }
        public required SizeEnum Size { get; set; }
        public required VaccineEnum Vaccine { get; set; }
        public required TreatmentEnum Treatment { get; set; }
        public ClientModel? ClientModel { get; set; }
    }
}