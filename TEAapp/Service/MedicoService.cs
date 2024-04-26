using Microsoft.EntityFrameworkCore;
using TEAapp.Data;
using TEAapp.Helper.Sessao;
using TEAapp.Models;
using TEAapp.Service.Interfaces;

namespace TEAapp.Service
{
    public class MedicoService : IMedicoService
    {
        private readonly AppDbContext _bancoContext;
        private readonly ISessao _sessao;

        public MedicoService(AppDbContext bancoContext, ISessao sessao)
        {
            _bancoContext = bancoContext;
            _sessao = sessao;
        }

        public async Task<Medico> BuscarMedico()
        {
            var usuarioSessao = _sessao.BuscarSessaoDoUsuario();

            return await _bancoContext.Medicos.FirstOrDefaultAsync(x => x.Id == usuarioSessao.Id);
        }

        public Task<bool> Delete(int id)
        {
            try
            {
                var usuarioSessao = _sessao.BuscarSessaoDoUsuario();
                _bancoContext.Medicos.Remove((Medico)usuarioSessao);
                _bancoContext.SaveChanges();

                return Task.FromResult(true);
            }
            catch (Exception)
            {

                return Task.FromResult(false);
            }

        }

        public Task<object> Editar(int id, Medico editar)
        {
            throw new NotImplementedException();
        }
    }
}
