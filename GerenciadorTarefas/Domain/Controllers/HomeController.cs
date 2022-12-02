using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.User;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Domain.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserModel user)
        {
            try
            {
                var savedUser = _userService.SaveUser(user);

                if (savedUser == true)
                {
                    TempData["MensagemSucesso"] = "Usuário cadastrada com sucesso";
                    return RedirectToAction("Login");
                }

                TempData["MensagemErro"] = $"Nào foi possivel registrar o usuário tente novamente";
                return View(user);
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um errro ao cadastrar o usuário, detalhe do erro: {ex.Message}";
                return View(user);

            }
        }
    }
}