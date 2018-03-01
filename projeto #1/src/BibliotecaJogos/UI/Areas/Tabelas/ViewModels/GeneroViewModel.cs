using Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Areas.Cadastros.ViewModels;

namespace UI.Areas.Tabelas.ViewModels
{
    public class GeneroViewModel
    {
        [Key]
        public long GeneroId { get; set; }
        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Deve conter ao menos 2 caractere")]
        public string Nome { get; set; }

        public virtual ICollection<JogoViewModel> Jogos { get; set; }
    }
}