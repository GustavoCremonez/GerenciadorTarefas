using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace GerenciadorTarefas.Data.Models
{
    public class UserModel
    {
        [Display(Name = "Código")]
        public long Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;
        [Display(Name = "Senha")]
        public string Password { get; set; } = string.Empty;
        public List<TaskModel> Tasks { get; set; }
    }
}
