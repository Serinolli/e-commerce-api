using Data.Context;
using Domain.Interfaces.Service.Commerce;

namespace Domain.Services.Commerce
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(DataContext context) : base(context)
        {

        }
    }
}
