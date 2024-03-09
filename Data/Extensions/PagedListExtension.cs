using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions
{
    public static class PagedListExtension
    {

        public async static Task<PagedList<T>> ToPagedList<T>(this IQueryable<T> source, int actualPage, int pageSize) where T : Entity
        {
            var registers = await source
                .Skip((actualPage - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedList<T>(registers, actualPage, pageSize);
        }

        public async static Task<PagedList<T>> ToPagedListWithoutEntity<T>(this IQueryable<T> source, int actualPage, int pageSize)
        {
            var registers = await source
                .Skip((actualPage - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedList<T>(registers, actualPage, pageSize);
        }
  
    }
}