using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Jogo
    {
        [Key]
        public long JogoId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int DataLancamento{ get; set; }
        public decimal Preco { get; set; }
        public byte NotaDoJogo { get; set; }

        
        public long GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        public long PlataformaId { get; set; }
        [ForeignKey("PlataformaId")]
        public Plataforma Plataforma { get; set; }

        public long ProdutoraId { get; set; }
        [ForeignKey("ProdutoraId")]
        public Produtora Produtora { get; set; }

        public string LogotipoMimeType { get; set; }
        public byte[] Logotipo { get; set; }
        public string NomeArquivo { get; set; }
        public long TamanhoArquivo { get; set; }

    }
}
