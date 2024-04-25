using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface ILoginService
    {
        Task<object> Logar(Login user);
        Task<T> BuscarPorEmail(string user);
        Task<T> AlterarSenha(T user);
    }
}
