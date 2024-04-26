using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface ILoginAdministradorService
    {
        Task<Administrador> Logar(Login user);
        Task<Administrador> BuscarPorEmail(string user);
        Task<Administrador> AlterarSenha(Administrador user);
    }
}
