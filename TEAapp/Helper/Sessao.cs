using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PontoMVC.Models;
using TEAapp.Models;

namespace TEAapp.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void CriarSessaoDoUsuario(Pessoa usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario); //Tenho que passar omeu obj usuario como string semperder as informações. Então ésó tranformar em um json.
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }
        public Pessoa BuscarSessaoDoUsuario()
        {
            //Em criarsessao foi trasformado em json. Aqui vamos montar o obj novamente.
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

        }
        public void RemoverSessaoUsuario()
        {
            //Agora vamos finalizar a nossa sessao
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
