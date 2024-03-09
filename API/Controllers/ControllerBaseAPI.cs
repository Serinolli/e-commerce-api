﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace API.Controllers
{
    public abstract class ControllerBaseAPI: ControllerBase
    {
        private readonly DbContext _context;
        private IDbContextTransaction? _transaction;
        public ControllerBaseAPI(DbContext context) 
        {
            _context = context;
        }
    }
}
