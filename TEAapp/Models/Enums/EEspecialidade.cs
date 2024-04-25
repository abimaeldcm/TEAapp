using System.ComponentModel.DataAnnotations;

namespace TEAapp.Models.Enums
{
    public enum EEspecialidade : int
    {
        Cardiologia,
        Oncologia,
        Ortopedia,
        Neurologia,
        Pediatria,
        Ginecologia,

        [Display(Name = "Cirurgia Plástica")]
        Cirurgia_Plástica,
        Dermatologia,
        Psiquiatria,
        Oftalmologia,
        Radiologia,
        Endocrinologia,
        Nefrologia,
        Urologia,
        Otorrinolaringologia,

        [Display(Name = "Cirurgia Plástica")]
        Cirurgia_Cardiovascular,
        Infectologia,
        Gastroenterologia,
        Hematologia,
        Anestesiologia
    }
}
