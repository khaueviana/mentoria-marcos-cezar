using Entidades;
using System.Data.Entity;

namespace DAL.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaJogos") { }

        DbSet<Genero> Generos { get; set; }
        DbSet<Produtora> Produtoras { get; set; }
        DbSet<Plataforma> Plataformas { get; set; }
        DbSet<Jogo> Jogos { get; set; }
    }
}
