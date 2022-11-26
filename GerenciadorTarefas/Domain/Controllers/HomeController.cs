using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Domain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}