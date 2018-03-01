using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UI.Areas.Tabelas.ViewModels;
namespace UI.Areas.Cadastros.ViewModels
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

        public string LogotipoMimeType { get; set; }
        public byte[] Logotipo { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }

    }
}