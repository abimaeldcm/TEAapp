using TEAapp.Models;
using TEAapp.Repository.Interfaces;

namespace TEAapp.Repository
{
    public class LoginAdminstradorRepository : ILoginAdministradorRepository
    {
        public Task<Administrador> AlterarSenha(Administrador user)
        {
            throw new NotImplementedException();
        }

        public Task<Administrador> BuscarPorEmail(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Administrador> Logar(Login user)
        {
            throw new NotImplementedException();
        }
    }
}
