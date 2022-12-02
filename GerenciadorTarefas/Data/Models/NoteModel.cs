using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorTarefas.Data.Models
{
    public class NoteModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O título da nota é obrigatório")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição da nota é obrigatório")]
        public string Description { get; set; } = string.Empty;

        [ForeignKey("User")]
        public long? UserId { get; set; }
        public UserModel? user { get; set; }
    }
}
