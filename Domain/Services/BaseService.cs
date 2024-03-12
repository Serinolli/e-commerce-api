using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class BaseService
    {
        #region Properties
        private readonly DbContext _context;
        private IDbContextTransaction? _transaction;
        #endregion

        #region Constructors
        public BaseService(DataContext context) 
        {
            _context = context;
        }
        #endregion

        #region Methods
        protected async Task BeginTransaction()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        protected async Task CommitTransaction()
        {
            await _transaction?.CommitAsync();
        }

        protected async Task ReverterTransacao()
        {
            await _transaction?.RollbackAsync();
        }
        #endregion
    }
}
