using Microsoft.EntityFrameworkCore;
using TEAapp.Data;
using TEAapp.Helper.Sessao;
using TEAapp.Models;
using TEAapp.Repository.Interfaces;

namespace TEAapp.Repository
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AppDbContext _bancoContext;
        private readonly ISessao _sessao;

        public MedicoRepository(AppDbContext bancoContext, ISessao sessao)
        {
            _bancoContext = bancoContext;
            _sessao = sessao;
        }

        public async Task<Medico> BuscarMedico()
        {
            var usuarioSessao = _sessao.BuscarSessaoDoUsuario();

            return await _bancoContext.Medicos.FirstOrDefaultAsync(x => x.Id == usuarioSessao.Id);
        }

        public Task<bool> Delete()
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

        public Task<Medico> Editar(int id, Medico editar)
        {
            try
            {
                var usuarioSessao = _sessao.BuscarSessaoDoUsuario();
                _bancoContext.Medicos.Remove((Medico)usuarioSessao);
                _bancoContext.SaveChanges();

                return Task.FromResult(editar);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
