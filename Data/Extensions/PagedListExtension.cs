using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions
{
    public static class PagedListExtension
    {

        public async static Task<PagedList<T>> ToPagedList<T>(this IQueryable<T> source, int numeroPagina, int tamanhoPagina) where T : Entity
        {
            var registros = await source
                .Skip((numeroPagina - 1) * tamanhoPagina)
                .Take(tamanhoPagina)
                .ToListAsync();

            return new PagedList<T>(registros, numeroPagina, tamanhoPagina);
        }

        public async static Task<PagedList<T>> ToPagedListSemEntity<T>(this IQueryable<T> source, int numeroPagina, int tamanhoPagina)
        {
            var registros = await source
                .Skip((numeroPagina - 1) * tamanhoPagina)
                .Take(tamanhoPagina)
                .ToListAsync();

            return new PagedList<T>(registros, numeroPagina, tamanhoPagina);
        }
  
    }
}