using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorTarefas.Data.Models
{
    public class TaskModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "O título da tarefa é obrigatório")]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int status { get; set; } = 3;

        [ForeignKey("User")]
        public long? UserId { get; set; }
        public UserModel? user { get; set; }
    }
}
