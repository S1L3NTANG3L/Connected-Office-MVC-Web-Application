using ConnectedOffice.Data.Data;
using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedOffice.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext connectedOfficeContext) : base(connectedOfficeContext)
        {
        }
        public Category GetCategoryByID(Guid? id)
        {
            return GetAll().FirstOrDefault(x => x.CategoryId == id);
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return GetAll().ToList();
        }
        public void AddCategory(Category entity)
        {
            Add(entity);
        }
        public void RemoveCategory(Category entity)
        {
            Remove(entity);
        }
        public void UpdateCategory(Category entity)
        {
            Update(entity);
        }
    }
}
