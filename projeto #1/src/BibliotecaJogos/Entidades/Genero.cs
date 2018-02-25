using System.Collections.Generic;

namespace Entidades
{
    public class Genero
    {
        public long GeneroId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
