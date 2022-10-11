using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Data.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetCategoryByID(Guid? id);
        IEnumerable<Category> GetAllCategories();
        void AddCategory(Category entity);
        void RemoveCategory(Category entity);
        void UpdateCategory(Category entity);
    }
}
