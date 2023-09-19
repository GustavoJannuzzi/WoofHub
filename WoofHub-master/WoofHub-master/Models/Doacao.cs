CentroCustoDoacaoEnum

using System.ComponentModel.DataAnnotations;
using WoofHub_App.Models.Enums;

namespace WoofHub_App.Models
{
    public class Doacao
    {
        [Key]
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public required CentroCustoDoacaoEnum CentroCusto { get; set; }
    }
}
