using Entidades;
using System.Data.Entity;

namespace DAL.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaJogos") { }

        DbSet<Genero> Generos { get; set; }
    }
}
