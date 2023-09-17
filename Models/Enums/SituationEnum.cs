using System.ComponentModel;

namespace WoofHub_App.Models.Enums
{
    public enum SituationEnum
    {
        [Description("Não adotado")]
        NotAdopted = 1,

        [Description("Adotado")]
        Adopted = 2,

        [Description("Lar temporário")]
        TemporaryHome = 3
    }
}