using System.ComponentModel;

namespace WoofHub_App.Models.Enums
{
    public enum CentroCustoDoacaoEnum
    {
        [Description("Custos com Pet")]
        NotAdopted = 1,

        [Description("Despesas Administrativas")]
        Adopted = 2,

    }
}