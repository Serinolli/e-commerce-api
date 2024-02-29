using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IRepository<TEntity>: IDisposable where TEntity : Entity
    {
        Task<PagedList<TEntity>> GetAll(bool includeInactive = false, PaginationParameters? parameters = null);
        Task<TEntity?> GetByQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes);
        Task<IEnumerable<TEntity?>> GetByQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity?> GetById(Guid id);
        Task<TEntity?> GetById(Guid id, params Expression<Func<TEntity, object>>[] includes);
        Task Add(TEntity entity);
        Task AddList(List<TEntity> entities);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
    }
}
