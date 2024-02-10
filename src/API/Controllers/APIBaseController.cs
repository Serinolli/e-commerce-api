using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIBaseController : ControllerBase
    {
        private IDbContextTransaction _transaction;
        private readonly DbContext _context;

        #region [ Protected Properties ]
        protected Guid UserId { get; set; }
        protected bool AuthenticatedUser { get; set; }
        #endregion
    }
}
