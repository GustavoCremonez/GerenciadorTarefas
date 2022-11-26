using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.Task
{
    public interface ITaskService
    {
        TaskModel SaveTask(TaskModel Task);
        TaskModel ChangeStatus(long id, int status);
        List<TaskModel> GetTasks();
        TaskModel GetTaskById(long id);
        TaskModel EditTask(TaskModel task);

        bool DeleteTask(long id);
    }
}
