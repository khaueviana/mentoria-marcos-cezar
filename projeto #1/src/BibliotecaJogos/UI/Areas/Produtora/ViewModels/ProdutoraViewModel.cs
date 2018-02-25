using Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UI.Areas.Produtora.ViewModels
{
    public class ProdutoraViewModel
    {
        [Key]
        public long ProdutoraId { get; set; }

        [Display(Name = "Produtora")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(50,ErrorMessage ="Tamanho máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage ="Deve conter ao menos 2 caractere")]
        public string Nome { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}