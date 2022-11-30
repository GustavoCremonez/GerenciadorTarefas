using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.Task
{
    public interface ITaskRepository
    {
        List<TaskModel> GetTasks();

        TaskModel GetTaskById(long id);

        TaskModel SaveTask(TaskModel task);

        TaskModel ChangeStatus(TaskModel task, int status);

        TaskModel EditTask(TaskModel task);

        bool DeleteTask(TaskModel task);
    }
}
