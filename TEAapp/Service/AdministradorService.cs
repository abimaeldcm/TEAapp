using TEAapp.Models;
using TEAapp.Service.Interfaces;

namespace TEAapp.Service
{
    public class AdministradorService : IAdministradorService
    {
        public Task<Administrador> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Administrador>> BuscarPorTexto(string termoPesquisa)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Administrador>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Administrador> Cadastrar(Administrador cadastrar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Editar(int id, Administrador editar)
        {
            throw new NotImplementedException();
        }
    }
}
