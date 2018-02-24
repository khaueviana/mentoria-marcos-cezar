using BLL.Interfaces;
using DAL.Interface;
using System.Collections.Generic;

namespace BLL.BLL
{
    public class PadraoBLL<TEntity> : IBLL<TEntity> where TEntity : class
    {

        public IMetodosCRUD<TEntity> contextObj { get; set; }

        public void Add(TEntity obj)
        {
            contextObj.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return contextObj.GetAll();
        }

        public TEntity GetById(long id)
        {
            return contextObj.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            contextObj.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            contextObj.Update(obj);
        }

    }
}
