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
        public DateTime DataLancamento{ get; set; }
        public decimal Preco { get; set; }
        public byte NotaDoJogo { get; set; }

        [ForeignKey("Genero")]
        public long GeneroId { get; set; }
        public Genero Genero { get; set; }

        [ForeignKey("Plataforma")]
        public long PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        [ForeignKey("Produtora")]
        public long ProdutoraId { get; set; }
        public Produtora Produtora { get; set; }
    }
}
