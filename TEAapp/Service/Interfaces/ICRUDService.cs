using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface ICRUDService<T> where T : class
    {
        Task<object> Logar(Login user);
        Task<T> BuscarPorEmail(string user);
        Task<T> AlterarSenha(T user);

        Task<T> BuscarPorId(int id);
        Task<IEnumerable<T>> BuscarPorTexto(string termoPesquisa);
        Task<IEnumerable<T>> BuscarTodos();
        Task<T> Cadastrar(T cadastrar);
        Task<bool> Delete(int id);
        Task<object> Editar(int id, T editar);
    }
}
