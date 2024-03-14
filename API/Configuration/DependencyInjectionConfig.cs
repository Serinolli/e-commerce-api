using Data.Context;
using Data.Repository.Commerce;
using Domain.Interfaces.Repository.Commerce;
using Domain.Interfaces.Service.Commerce;
using Domain.Services.Commerce;

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
            services.AddScoped<DataContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            #endregion
            return services;
        }
    }
}
