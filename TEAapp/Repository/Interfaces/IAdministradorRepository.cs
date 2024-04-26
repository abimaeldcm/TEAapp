using TEAapp.Models;

namespace TEAapp.Repository.Interfaces
{
    public interface IAdministradorRepository
    {
        Task<Administrador> BuscarPorId(int id);
        Task<IEnumerable<Administrador>> BuscarPorTexto(string termoPesquisa);
        Task<IEnumerable<Administrador>> BuscarTodos();
        Task<Administrador> Cadastrar(Administrador cadastrar);
        Task<bool> Delete(int id);
        Task<object> Editar(int id, Administrador editar);
    }
}
