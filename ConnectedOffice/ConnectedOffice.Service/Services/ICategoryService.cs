using ConnectedOffice.Data.Models;
using System;
using System.Collections.Generic;

namespace ConnectedOffice.Service.Services
{
    public interface ICategoryService
    {
        Category GetCategoryById(Guid? id);
        IEnumerable<Category> GetAllCategorys();
        void AddCategory(Category entity);
        void RemoveCategory(Category entity);
        void UpdateCategory(Category entity);
    }
}
