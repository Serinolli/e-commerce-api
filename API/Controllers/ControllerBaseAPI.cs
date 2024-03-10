using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace API.Controllers
{
    public abstract class ControllerBaseAPI : ControllerBase
    {
        private readonly DataContext _context;
        public ControllerBaseAPI(DataContext context)
        {
            _context = context;
        }
    }
}
