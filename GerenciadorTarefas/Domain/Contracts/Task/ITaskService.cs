using GerenciadorTarefas.Data.Models;

namespace GerenciadorTarefas.Domain.Contracts.Task
{
    public interface ITaskService
    {
        public TaskModel SaveTask(TaskModel Task);
    }
}
