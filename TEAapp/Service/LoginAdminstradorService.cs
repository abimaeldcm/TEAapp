using TEAapp.Models;
using TEAapp.Service.Interfaces;

namespace TEAapp.Service
{
    public class LoginAdminstradorService : ILoginAdministradorService
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
