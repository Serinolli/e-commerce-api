using Domain.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository.Commerce
{
    public interface ICategoryRepository: IRepository<Category>
    {
        public Task<Category?> GetByName(string name);
    }
}
