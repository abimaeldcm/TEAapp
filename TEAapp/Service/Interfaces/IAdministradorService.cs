using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface IAdministradorService
    {
        Task<Administrador> BuscarPorId(int id);
        Task<IEnumerable<Administrador>> BuscarPorTexto(string termoPesquisa);
        Task<IEnumerable<Administrador>> BuscarTodos();
        Task<Administrador> Cadastrar(Administrador cadastrar);
        Task<bool> Delete(int id);
        Task<object> Editar(int id, Administrador editar);
    }
}
