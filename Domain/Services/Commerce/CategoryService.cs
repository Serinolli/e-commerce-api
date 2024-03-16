using Domain.Interfaces.Repository.Commerce;
using Domain.Interfaces.Service.Commerce;
using Domain.Models;
using Domain.Models.Commerce;

namespace Domain.Services.Commerce
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task Create(Category category)
        {
            return _categoryRepository.Add(category);
        }

        public Task<PagedList<Category>> GetAll()
        {
            return _categoryRepository.GetAll();
        }
    }
}
