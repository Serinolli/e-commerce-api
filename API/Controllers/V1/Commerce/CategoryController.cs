using Data.Context;
using Domain.Interfaces.Repository.Commerce;
using Domain.Models.Commerce;
using Microsoft.AspNetCore.Mvc; // Assuming your DataContext resides in this namespace

namespace API.Controllers.V1.Commerce
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBaseAPI
    {
        #region Properties
        private readonly ICategoryRepository _categoryRepository;
        #endregion
        public CategoryController(
            DataContext context,
            ICategoryRepository categoryRepository
            ) : base(context)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<Category> GetCategory()
        {
            return await _categoryRepository.GetByName("Teste");
        }
    }
}
