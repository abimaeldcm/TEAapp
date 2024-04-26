using TEAapp.Models.Enums;

namespace TEAapp.Models
{
    public class Medico : Pessoa
    {
        public string Descricao { get; set; }
        public string CRM { get; set; }
        public EEspecialidade Especialidades { get; set; }
    }
}
