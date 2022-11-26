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

        public TaskModel ChangeStatus(long id, int status)
        {
            var taskInDB = _context.Tasks.Where(x => x.Id == id).FirstOrDefault();

            if (taskInDB != null)
            {
                taskInDB.status = status;
                _context.SaveChanges();
                return taskInDB;
            }
            throw new ArgumentNullException();
        }

        public TaskModel GetTaskById(long id)
        {
            var task = _context.Tasks.Where(x => x.Id == id).FirstOrDefault();
            if (task != null)
            {
                return task;
            }
            throw new ArgumentNullException();
        }

        public TaskModel EditTask(TaskModel task)
        {
            var taskInDb = this.GetTaskById(task.Id);

            if (taskInDb != null)
            {
                taskInDb.Title = task.Title;
                taskInDb.Description = task.Description;
                taskInDb.status = taskInDb.status;
                taskInDb.UserId = taskInDb.UserId;

                _context.SaveChanges();
                return task;
            }
            throw new ArgumentNullException();
        }

        public bool DeleteTask(long id)
        {
            var taskInDb = this.GetTaskById(id);

            if (taskInDb != null)
            {
                _context.Tasks.Remove(taskInDb);
                _context.SaveChanges();

                return true;
            }

            throw new ArgumentNullException(nameof(id));
        }
    }
}
