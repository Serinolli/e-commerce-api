using Data.Context;
using Domain.Interfaces.Repository.Commerce;
using Domain.Interfaces.Service.Commerce;
using Domain.Models;
using Domain.Models.Commerce;
using Microsoft.AspNetCore.Mvc; // Assuming your DataContext resides in this namespace

namespace API.Controllers.V1.Commerce
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBaseAPI
    {
        #region Properties
        private readonly ICategoryService _categoryService;
        #endregion
        public CategoryController(
            DataContext context,
            ICategoryService categoryService
            ) : base(context)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public Task CreateCategory([FromBody] Category category)
        {
            return _categoryService.Create(category);
        }

        [HttpPut]
        public Task UpdateCategory([FromBody] Category category)
        {
            return _categoryService.Update(category);
        }

        [HttpGet]
        public async Task<PagedList<Category>> GetCategories()
        {
            return await _categoryService.GetAll();
        }
    }
}
