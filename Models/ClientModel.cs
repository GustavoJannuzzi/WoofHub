using System.ComponentModel.DataAnnotations;

namespace WoofHub_App.Models
{
    public class ClientModel
    {   
        [Key]
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? ClientCpf { get; set; }
        public required AdressModel ClientAdress { get; set; }
    }
}