using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;
using GerenciadorTarefas.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Domain.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskService _taskService;
        public TaskController(ITaskRepository taskRepository, ITaskService taskService)
        {
            _taskRepository = taskRepository;
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            var tasks = _taskRepository.GetTasks();

            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaskModel task)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _taskService.SaveTask(task);
                    TempData["MensagemSucesso"] = "Tarefa cadastrada com sucesso";
                    return RedirectToAction("Index");
                }
                return View(task);
            }catch(Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um errro ao cadastrar o contato, detalhe do erro: {ex.Message}";
                return RedirectToAction("Create", task);
            }
        }
    }
}
