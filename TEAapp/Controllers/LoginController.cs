using Microsoft.AspNetCore.Mvc;
using TEAapp.Helper.Email;
using TEAapp.Helper.Sessao;
using TEAapp.Models;
using TEAapp.Service;
using TEAapp.Service.Interfaces;

namespace TEAapp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginMedicoService _loginService;
        private readonly IMedicoService _service;
        private readonly ISessao _session;
        private readonly IEmailService _emailService;
        private readonly VerificadorCodigoService _VerificadorDeCodigoService;

        public LoginController(ILoginMedicoService loginService, IMedicoService service, ISessao session, IEmailService emailService, VerificadorCodigoService verificadorDeCodigoService)
        {
            _loginService = loginService;
            _service = service;
            _session = session;
            _emailService = emailService;
            _VerificadorDeCodigoService = verificadorDeCodigoService;
        }

        public IActionResult Index()
        {
            try
            {
                if (_session.BuscarSessaoDoUsuario() != null)
                {
                    TempData["MensagemSucesso"] = "Seja bem vindo! Você já está logado!";
                    return RedirectToAction("Index", "Home");
                }

                return View();

            }
            catch
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> Logar(Login usuario)
        {
            try
            {
                Pessoa usuarioDB = await _loginService.Logar(usuario);
                if (usuarioDB != null)
                {
                    _session.CriarSessaoDoUsuario(usuarioDB);
                    return RedirectToAction("Index", "Home");
                }
                TempData["MensagemErro"] = "Login ou senha estão incorretos";

                return View("Index");
            }
            catch
            {
                TempData["MensagemErro"] = "Um erro ocorreu ao logar. Tente novamente";
                return View("Index");
            }
        }
       /* public IActionResult EsqueciSenha()
        {
            return View("PrimeiroLogin");
        }

        public IActionResult PrimeiroLogin()
        {
            return View();

        }
        [HttpPost]
        public IActionResult PrimeiroLogin(string email)
        {
            var usuarioExiste = _service.BuscarPorEmail(email);
            if (usuarioExiste != null)
            {
                int codigo = _VerificadorDeCodigoService.GerarCodigo();

                _emailService.SendEmailAsync(email,
                    "Código de Recuperação",
                $"Seu código de recuperação é: {codigo} \n Código válido por 10 minutos.");

                _VerificadorDeCodigoService.GuardarEmailCache(email);

                TempData["MensagemSucessoEnvio"] = "Encaminhamos um código de recuperação para o seu e-mail";
                return RedirectToAction("ConfirmacaoCodigo");
            }
            else
            {
                TempData["MensagemEmailNaoEncontrado"] = "Não encontramos o e-mail informado. Verifique as informações ou entre em contato com o seu administrador.";
                return View("PrimeiroLogin");
            }

        }
        public IActionResult ConfirmacaoCodigo()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ConfirmacaoCodigo(string codigo)
        {
            var codigoIgual = _VerificadorDeCodigoService.ValidarCodigoEnviado(codigo);

            if (codigoIgual)
            {
                return RedirectToAction("AlterarSenha");
            }

            TempData["CodigoIncorreto"] = "O código informado não corresponde ao enviado para o seu e-mail. Tente novamente.";

            return View();
        }

        public IActionResult AlterarSenha()
        {

            return View();
        }
        [HttpPost]
        public async IActionResult AlterarSenha(string NovaSenha, string ConfirmarNovaSenha)
        {
            if (NovaSenha != ConfirmarNovaSenha)
            {
                ModelState.AddModelError("ConfirmarNovaSenha", "As senhas não correspondem.");
                return View();
            }

            var email = _VerificadorDeCodigoService.RecuperarEmailCache();

            if (email == null)
            {
                //colocar a excessão aqui
                return View();
            }

            Pessoa Usuario = await _service.BuscarPorEmail(email);
            Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(NovaSenha);

            await _service.AlterarSenha(Usuario);

            TempData["SenhaAlterada"] = "Sua senha foi alterada com sucesso!";

            return RedirectToAction("Index", "Login");
        }

        */

    }
}
