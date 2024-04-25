using TEAapp.Models;
using TEAapp.Service.Interfaces;

namespace TEAapp.Service
{
    public class LoginService : ICRUDService<Login>
    {
        public Task<Login> Logar(Login user)
        {
            throw new NotImplementedException();
        }
        public Task<Login> AlterarSenha(Login user)
        {
            throw new NotImplementedException();
        }

        public Task<Login> BuscarPorEmail(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Login> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Login>> BuscarPorTexto(string termoPesquisa)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Login>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Login> Cadastrar(Login cadastrar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Editar(int id, Login editar)
        {
            throw new NotImplementedException();
        }

        
    }
}
