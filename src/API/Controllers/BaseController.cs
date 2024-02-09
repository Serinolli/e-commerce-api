using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace API.Controllers 
{
    [ApiController]
    public abstract class APIControllerBase : ControllerBase 
    {
        private IDbContextTransaction _transaction;
        private readonly DbContext _context;

        #region [ Protected Properties ]
        protected Guid UserId { get; set; }
        protected bool AuthenticatedUser{ get; set; }
        #endregion
    }
}