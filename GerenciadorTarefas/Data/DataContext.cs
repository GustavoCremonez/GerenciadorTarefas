using GerenciadorTarefas.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
