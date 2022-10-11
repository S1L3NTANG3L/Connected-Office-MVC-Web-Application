using System.Collections.Generic;

namespace ConnectedOffice.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
