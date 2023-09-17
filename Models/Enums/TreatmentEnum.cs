using System.ComponentModel;

namespace WoofHub_App.Models
{
    public enum TreatmentEnum
    {
        [Description("Necessita tratamento")]
        NeedTreatment = 1,

        [Description("Em tratamento")]
        InTreatment = 2,

        [Description("Não necessita tratamento")]
        NotTreatment = 3,

        [Description("Tratado")]
        Treated = 4
    }
}