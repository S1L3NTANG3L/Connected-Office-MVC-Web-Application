using ConnectedOffice.Data.Data;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.AddAsync(entity);
                _context.SaveChanges();//Change
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return _context.Set<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
        public void Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't remove entity: {ex.Message}");
            }
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }
            try
            {
                _context.Update(entity);
                _context.SaveChanges();//Change
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}
