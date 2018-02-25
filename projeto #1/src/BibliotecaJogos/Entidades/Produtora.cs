using System.Collections.Generic;

namespace Entidades
{
    public class Produtora
    {
        public long  ProdutoraId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
