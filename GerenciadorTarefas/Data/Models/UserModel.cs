using System.ComponentModel.DataAnnotations;

namespace GerenciadorTarefas.Data.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo email é obrigatório")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo senha é obrigatório")]
        public string Password { get; set; } = string.Empty;
        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();
        public List<NoteModel> Notes { get; set; } = new List<NoteModel>();
    }
}
