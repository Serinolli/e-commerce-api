using Microsoft.AspNetCore.Mvc;

namespace API.Controllers 
{
    [ApiController]
    public abstract class APIControllerBase : ControllerBase 
    {
        private IDbContextTransaction _transaction
        private readonly DbContext _context;
    }
}