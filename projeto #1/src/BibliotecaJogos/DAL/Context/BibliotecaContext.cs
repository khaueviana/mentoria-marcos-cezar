using Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaJogos") { }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Jogo> Jogos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
