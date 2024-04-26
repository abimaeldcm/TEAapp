using TEAapp.Models;

namespace TEAapp.Repository.Interfaces
{
    public interface ILoginMedicoRepository
    {
        Task<Medico> Logar(Login user);
        Task<Medico> BuscarPorEmail(string user);
        Task<Medico> AlterarSenha(Medico user);
    }
}
