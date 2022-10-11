using ConnectedOffice.Data.Models;
using ConnectedOffice.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedOffice.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public IEnumerable<Category> GetAllCategorys()
        {
            return _categoryRepository.GetAll().ToList();
        }

        public Category GetCategoryById(Guid? id)
        {
            return _categoryRepository.GetAll().FirstOrDefault(x => x.CategoryId == id);
        }

        public void RemoveCategory(Category entity)
        {
            _categoryRepository.Remove(entity);
        }

        public void UpdateCategory(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
