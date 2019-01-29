using System.ComponentModel.DataAnnotations;

namespace TreeGeneric.Model
{
    public enum Gender
    {
        [Display(Name = "Erkek")]
        Male = 1,
        [Display(Name = "Kadın")]
        Female = 2
    }
}