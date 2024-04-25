using TEAapp.Models;

namespace TEAapp.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(object usuario);
        void RemoverSessaoUsuario();
        object BuscarSessaoDoUsuario();
    }
}
