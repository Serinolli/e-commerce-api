﻿using Domain.Models;
using Domain.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service.Commerce
{
    public interface ICategoryService
    {
        public Task Create(Category category);
        public Task Update(Category category);
        public Task<PagedList<Category>> GetAll();
    }
}
