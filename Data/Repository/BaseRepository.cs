using Data.Context;
using Data.Extensions;
using Domain.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        private readonly DbSet<TEntity> dbSet;
        protected readonly DataContext DbContext;

        protected BaseRepository(DataContext dbContext)
        {
            DbContext = dbContext;
            dbSet = DbContext.Set<TEntity>();
        }
        private async Task<int> SaveChanges()
        {
            return await DbContext.SaveChangesAsync();
        }
        #region Query Methods
        protected IQueryable<TEntity> GetQuery(bool includeInactive = false)
        {
            if (includeInactive)
                return dbSet.AsNoTracking().IgnoreQueryFilters();
            else
                return dbSet.AsNoTracking();
        }
        private IQueryable<TEntity> GetSearchQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = this.GetQuery(includeInactive);

            foreach (var include in includes)
                query = query.Include(include);

            if (condition != null)
                query = query.Where(condition);

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }
        #endregion


        public async Task Add(TEntity entity)
        {
            dbSet.Add(entity);
            await SaveChanges();
        }

        public async Task AddList(List<TEntity> entities)
        {
            dbSet.AddRange(entities);
            await SaveChanges();
        }
        public async Task Remove(TEntity entity)
        {
            dbSet.Remove(entity);
            await SaveChanges();
        }

        public async Task Update(TEntity entity)
        {
            dbSet.Update(entity);
            await SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public async Task<PagedList<TEntity>> GetAll(bool includeInactive = false, PaginationParameters? parameters = null)
        {
            return await this.GetQuery(includeInactive)
                .ToPagedList(parameters?.CurrentPage ?? 1, parameters?.PageSize ?? 20);
        }

        public virtual async Task<TEntity?> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<TEntity?> GetById(Guid id, params Expression<Func<TEntity, object>>[] includes)
        {
            foreach (Expression<Func<TEntity, object>> include in includes)
                dbSet.Include(include);

            return await dbSet.FindAsync(id);
        }

        public async Task<TEntity?> GetByQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = this.GetQuery(includeInactive);

            foreach (Expression<Func<TEntity, object>> include in includes)
                query = query.Include(include);

            return await query.FirstOrDefaultAsync(condition);
        }

        public async Task<IEnumerable<TEntity?>> GetByQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = this.GetSearchQuery(includeInactive, condition, orderBy, includes);

            return await query.ToListAsync();
        }
    }
}
