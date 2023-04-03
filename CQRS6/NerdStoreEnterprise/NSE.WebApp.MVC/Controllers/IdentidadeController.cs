using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Controllers
{
    public class IdentidadeController : Controller
    {
        [HttpGet]
        [Route("nova-conta")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [Route("nova-conta")]
        public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid) return View(usuarioRegistro);

            //Api - Registro

            if (false) return View(usuarioRegistro);

            //Realizar login na Aplicação

            return RedirectToAction("index", "Home");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(UsuarioLogin usuariologin)
        {
            if (!ModelState.IsValid) return View(usuariologin);

            //Api - Login

            if (false) return View(usuariologin);

            //Realizar login na Aplicação

            return RedirectToAction("index", "Home");
        }

        [HttpGet]
        [Route("sair")]

        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}