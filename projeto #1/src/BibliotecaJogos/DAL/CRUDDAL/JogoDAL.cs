using DAL.Context;
using DAL.Interface;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CRUDDAL
{
    public class JogoDAL : PadraoDAL<Jogo>, IJogoDAL
    {
        public override IEnumerable<Jogo> GetAll()
        {
            return context.Jogos.Include("Plataforma").Include("Produtora").Include("Genero");
        }

        public override Jogo GetById(long id)
        {
            return context.Jogos.Include("Plataforma").Include("Produtora").Include("Genero").Where(j => j.JogoId == id).First();
        }

        public override void Update(Jogo jogo)
        {
            var local = context.Set<Jogo>()
                            .Local
                            .FirstOrDefault(f => f.JogoId == jogo.JogoId);

            context.Entry(local).State = System.Data.Entity.EntityState.Detached;
            context.Entry(jogo).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
