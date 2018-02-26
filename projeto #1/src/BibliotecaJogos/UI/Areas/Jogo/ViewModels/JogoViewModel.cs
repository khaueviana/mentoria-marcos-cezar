using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UI.Areas.Genero.ViewModels;
using UI.Areas.Plataforma.ViewModels;
using UI.Areas.Produtora.ViewModels;

namespace UI.Areas.Jogo.ViewModels
{
    public class JogoViewModel
    {

        [Key]
        public long JogoId { get; set; }

        [Required]
        [Display(Name ="Jogo")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [Display(Name="Ano de Lançamento")]
        [MaxLength(4)]
        public int DataLancamento { get; set; }

        [Display(Name = "Preço")]
        [Range(0,9990.99)]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required]
        [Display(Name ="Nota do Jogo")]
        [Range(0,100)]
        public byte NotaDoJogo { get; set; }

        [Required]
        public long GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public GeneroViewModel Genero { get; set; }

        [Required]
        public long PlataformaId { get; set; }
        [ForeignKey("PlataformaId")]
        public PlataformaViewModel Plataforma { get; set; }

        [Required]
        public long ProdutoraId { get; set; }
        [ForeignKey("ProdutoraId")]
        public ProdutoraViewModel Produtora { get; set; }
    }
}