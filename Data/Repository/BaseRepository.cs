using Data.Context;
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
        protected IQueryable<TEntity> GetQuery(bool includeInactive = false)
        {
            if (includeInactive)
                return dbSet.AsNoTracking().IgnoreQueryFilters();
            else
                return dbSet.AsNoTracking();
        }


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

        public Task<PagedList<TEntity>> GetAll(bool includeInactive = false, PaginationParameters? parameters = null)
        {
            throw new NotImplementedException();
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

        public Task<IEnumerable<TEntity?>> GetByQuery(bool includeInactive, Expression<Func<TEntity, bool>> condition, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }
    }
}
