using BLL.Interfaces;
using DAL.CRUDDAL;
using Entidades;

namespace BLL.BLL
{
    public class ProdutoraBLL : PadraoBLL<Produtora>, IProdutoraBLL
    {
        private ProdutoraDAL obj = new ProdutoraDAL();

        public ProdutoraBLL()
        {
            base.contextObj = obj;
        }
    }
}
