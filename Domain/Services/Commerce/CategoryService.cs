using Data.Context;
using Domain.Interfaces.Repository.Commerce;
using Domain.Interfaces.Service.Commerce;
using Domain.Models.Commerce;

namespace Domain.Services.Commerce
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(DataContext context, ICategoryRepository categoryRepository) : base(context) 
        {
            _categoryRepository = categoryRepository;
        }

        public Task Create(Category category)
        {
            return _categoryRepository.Add(category);
        }
    }
}
