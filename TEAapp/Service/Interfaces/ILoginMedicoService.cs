using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface ILoginMedicoService
    {
        Task<Medico> Logar(Login user);
        Task<Medico> BuscarPorEmail(string user);
        Task<Medico> AlterarSenha(Medico user);
    }
}
