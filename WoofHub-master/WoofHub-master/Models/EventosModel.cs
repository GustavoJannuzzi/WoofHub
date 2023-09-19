using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class EventosModel
    {
        [Key]
        public string NomeEvento { get; set; }
        public string? Description { get; set; }
        public DateTime Data  { get; set; }
        public string LocalEvento { get; set; }

    }
}