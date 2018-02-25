using System.Collections.Generic;

namespace Entidades
{
    public class Plataforma
    {
        public long PlataformaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
