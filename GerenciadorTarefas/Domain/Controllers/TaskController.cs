using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.Domain.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            var tasks = _taskService.GetTasks();

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
                _taskService.SaveTask(task);
                TempData["MensagemSucesso"] = "Tarefa cadastrada com sucesso";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um errro ao cadastrar o contato, detalhe do erro: {ex.Message}";
                return RedirectToAction("Create", task);
            }
        }

        public IActionResult ChangeStatus(int id, int status)
        {
            try
            {
                _taskService.ChangeStatus(id, status);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um erro ao atualizar o status da tarefa, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult EditTask(int id)
        {
            var task = _taskService.GetTaskById(id);

            return task != null ? View(task) : RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditTask(TaskModel task)
        {
            try
            {
                _taskService.EditTask(task);
                TempData["MensagemSucesso"] = "Tarefa editada com sucesso";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um erro ao editar a tarefa, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult DeleteTask(int id)
        {
            try
            {
                _taskService.DeleteTask(id);
                TempData["MensagemSucesso"] = "Tarefa removida com sucesso";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Houve um erro ao remover a tarefa, detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
