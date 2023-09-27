using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Data.DTOs
{
    public class AnimalDTO
    {
        [Required]
        [StringLength(100)]
        public string? AnimalName { get; set; }

        [Required]
        [StringLength(100)]
        public string? Age { get; set; }
        
        [StringLength(5000, ErrorMessage = "A descrição deve ter no máximo 5000 caractereres")]
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