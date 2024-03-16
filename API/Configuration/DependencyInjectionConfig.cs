using Data.Context;
using Data.Repository.Commerce;
using Domain.Interfaces.Repository.Commerce;
using Domain.Interfaces.Service.Commerce;
using Domain.Services.Commerce;
using Microsoft.EntityFrameworkCore;

namespace API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(
                this IServiceCollection services
            )
        {
            #region Services
            services.AddScoped<ICategoryService, CategoryService>();
            #endregion

            #region Repositories
            //services.AddScoped<IRepository, Repository>;
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            #endregion

            services.AddScoped<DbContext>();
            return services;
        }
    }
}
