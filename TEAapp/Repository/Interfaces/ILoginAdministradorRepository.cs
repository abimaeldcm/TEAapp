using TEAapp.Models;

namespace TEAapp.Repository.Interfaces
{
    public interface ILoginAdministradorRepository
    {
        Task<Administrador> Logar(Login user);
        Task<Administrador> BuscarPorEmail(string user);
        Task<Administrador> AlterarSenha(Administrador user);
    }
}
