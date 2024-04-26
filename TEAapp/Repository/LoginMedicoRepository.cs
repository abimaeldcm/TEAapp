using TEAapp.Models;
using TEAapp.Repository.Interfaces;

namespace TEAapp.Repository
{
    public class LoginMedicoRepository : ILoginMedicoRepository
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
