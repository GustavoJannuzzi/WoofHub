using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class AnimalModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public int? Age { get; set; }
        
        [MaxLength(5000, ErrorMessage = "A descrição deve ter no máximo 5000 caractereres")]
        public string? Description { get; set; }

        [Required]
        public AnimalEnum Animal { get; set; }

        [Required]
        public SituationEnum Situation { get; set; }

        [Required]
        public SizeEnum Size { get; set; }

        [Required]
        public VaccineEnum Vaccine { get; set; }

        [Required]
        public required TreatmentEnum Treatment { get; set; }
        public ClientModel? ClientModel { get; set; }
    }
}