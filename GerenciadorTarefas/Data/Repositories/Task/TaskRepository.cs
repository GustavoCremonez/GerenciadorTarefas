using GerenciadorTarefas.Data.Models;
using GerenciadorTarefas.Domain.Contracts.Task;

namespace GerenciadorTarefas.Data.Repositories.Task
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _context;
        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public List<TaskModel> GetTasks()
        {
            return _context.Tasks.ToList();
        }

        public TaskModel SaveTask(TaskModel task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();

            return task;
        }
    }
}
