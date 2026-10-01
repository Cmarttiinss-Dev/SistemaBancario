using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Controllers
{
    public class BancoController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string tipoAcesso, string senha, string numeroConta)
        {
            return View();
        }
        [HttpGet]
        public IActionResult MinhaConta(string numero)
        {
            return View():
        }
        [HttpGet]
        public ActionResult RealizarTransacao(string numeroConta, string tipoAcesso)
        {
            return View();
        }
        [HttpGet]
        public ActionResult PainelGerente()
        {
            return View();
        }
    }
}
