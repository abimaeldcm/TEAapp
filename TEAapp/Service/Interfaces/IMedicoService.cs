using TEAapp.Models;

namespace TEAapp.Service.Interfaces
{
    public interface IMedicoService
    {
        Task<Medico> BuscarMedico();
        //Task<IEnumerable<Medico>> BuscarPorTexto(string termoPesquisa);
        //Task<IEnumerable<Medico>> BuscarTodos();
        //Task<Medico> Cadastrar(Medico cadastrar);
        Task<bool> Delete(int id);
        Task<object> Editar(int id, Medico editar);
    }
}
