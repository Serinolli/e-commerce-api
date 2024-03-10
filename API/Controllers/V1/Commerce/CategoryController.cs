using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Commerce
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBaseAPI
    {
        public CategoryController(DbContext context) : base(context) 
        {
            
        }
    }
}
