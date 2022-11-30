using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Domain.Controllers
{
    public class NoteController : Controller
    {
        //private readonly IUserService _userService;
        //public HomeController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}