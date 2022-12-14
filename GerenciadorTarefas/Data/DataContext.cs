using GerenciadorTarefas.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorTarefas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
    }
}
