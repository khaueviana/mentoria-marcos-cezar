using BLL.Interfaces;
using DAL.CRUDDAL;
using Entidades;

namespace BLL.BLL
{
    public class GeneroBLL : PadraoBLL<Genero>, IGeneroBLL
    {
        private GeneroDAL obj = new GeneroDAL();

        public GeneroBLL()
        {
            base.contextObj = obj;
        }
    }
}
