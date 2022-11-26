using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;

namespace GerenciadorTarefas.Domain.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository) {
            _taskRepository= taskRepository;
        }

        public TaskModel SaveTask(TaskModel task)
        {
            return _taskRepository.SaveTask(task);
        }

        public TaskModel ChangeStatus(int id, int status)
        {
            return _taskRepository.ChangeStatus(id, status);
        }
    }
}
