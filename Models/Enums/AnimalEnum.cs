using System.ComponentModel;

namespace WoofHub_App.Models
{
    public enum AnimalEnum
    {
        [Description("Cachorro")]
        Dog = 1,

        [Description("Gato")]
        Cat = 2
    }
}