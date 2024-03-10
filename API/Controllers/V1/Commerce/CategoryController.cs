using Data.Context;
using Microsoft.AspNetCore.Mvc; // Assuming your DataContext resides in this namespace

namespace API.Controllers.V1.Commerce
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBaseAPI
    {
        public CategoryController(DataContext context) : base(context)
        {

        }
    }
}
