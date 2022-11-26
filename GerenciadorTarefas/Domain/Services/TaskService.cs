using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;

namespace GerenciadorTarefas.Domain.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public TaskModel SaveTask(TaskModel task)
        {
            return _taskRepository.SaveTask(task);
        }

        public TaskModel ChangeStatus(long id, int status)
        {
            return _taskRepository.ChangeStatus(id, status);
        }

        public List<TaskModel> GetTasks()
        {
            return _taskRepository.GetTasks();
        }

        public TaskModel GetTaskById(long id)
        {
            return _taskRepository.GetTaskById(id);
        }

        public TaskModel EditTask(TaskModel task)
        {
            return _taskRepository.EditTask(task);
        }

        public bool DeleteTask(long id)
        {
            return _taskRepository.DeleteTask(id);
        }
    }
}
