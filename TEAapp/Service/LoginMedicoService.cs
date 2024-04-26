using TEAapp.Models;
using TEAapp.Service.Interfaces;

namespace TEAapp.Service
{
    public class LoginMedicoService : ILoginMedicoService
    {
        public Task<Medico> AlterarSenha(Medico user)
        {
            throw new NotImplementedException();
        }

        public Task<Medico> BuscarPorEmail(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Medico> Logar(Login user)
        {
            throw new NotImplementedException();
        }
    }
}
