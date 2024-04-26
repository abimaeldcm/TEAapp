using TEAapp.Models;

namespace TEAapp.Helper.Sessao
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(Pessoa usuario);
        void RemoverSessaoUsuario();
        Pessoa BuscarSessaoDoUsuario();
    }
}
