using Data.Context;
using Domain.Interfaces.Repository.Commerce;
using Domain.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Commerce
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataContext context): base(context) { }

        public Task<Category?> GetByName(string name)
        {
            return Task.FromResult(
                    GetQuery()
                        .SingleOrDefault(u => u.Name.Equals(name))
                );
        }

    }
}