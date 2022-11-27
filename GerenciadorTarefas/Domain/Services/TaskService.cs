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
            var taskInDB = _taskRepository.GetTaskById(id);

            if (taskInDB != null)
            {
                return _taskRepository.ChangeStatus(taskInDB, status);
            }
            throw new ArgumentNullException(nameof(taskInDB));
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
            var taskInDB = _taskRepository.GetTaskById(id);

            if (taskInDB != null)
            {
                return _taskRepository.DeleteTask(taskInDB);
            }
            return false;
        }
    }
}
