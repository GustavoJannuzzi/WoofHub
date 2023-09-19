using System.ComponentModel;

namespace WoofHub_App.Models
{
    public enum VaccineEnum
    {
        [Description("Já vacinado")]
        Vaccinated = 1,

        [Description("Precisa vacinar")]
        NeedVaccine = 2,

        [Description("Sem Vacina")]
        NoVaccine = 3
    }
}