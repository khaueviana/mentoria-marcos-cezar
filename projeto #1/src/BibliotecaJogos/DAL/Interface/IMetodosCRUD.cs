using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IMetodosCRUD<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(long id);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);

    }
}
