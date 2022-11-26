using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.Task
{
    public interface ITaskRepository
    {
        List<TaskModel> GetTasks();
        TaskModel SaveTask(TaskModel task);
        TaskModel ChangeStatus(int id, int status);
    }
}
