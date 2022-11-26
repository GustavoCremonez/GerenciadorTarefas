using GerenciadorTarefas.Data.Models.utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorTarefas.Data.Models
{
    public class TaskModel
    {
        [Display(Name = "Código")]
        public long Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Código do usuário")]
        [ForeignKey("User")]
        public long IdUser { get; set; }
        public UserModel user { get; set; }

        [Display(Name = "Status")]
        public int status { get; }
    }
}
