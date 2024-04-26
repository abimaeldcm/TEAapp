using TEAapp.Models;

namespace TEAapp.Repository.Interfaces
{
    public interface IMedicoRepository
    {
        Task<Medico> BuscarMedico();
        //Task<IEnumerable<Medico>> BuscarPorTexto(string termoPesquisa);
        //Task<IEnumerable<Medico>> BuscarTodos();
        //Task<Medico> Cadastrar(Medico cadastrar);
        Task<bool> Delete();
        Task<Medico> Editar(int id, Medico editar);
    }
}
