using BLL.Interfaces;
using DAL.CRUDDAL;
using Entidades;

namespace BLL.BLL
{
    public class PlataformaBLL : PadraoBLL<Plataforma>, IPlataformaBLL
    {
        private PlataformaDAL plataformaDAL = new PlataformaDAL();

        public PlataformaBLL()
        {
            base.contextObj = plataformaDAL;
        }
    }
}
