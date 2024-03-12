using Data.Context;
using Data.Repository.Commerce;
using Domain.Interfaces.Repository.Commerce;

namespace API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(
                this IServiceCollection services
            )
        {
            //services.AddScoped<IRepository, Repository>;
            services.AddScoped<DataContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
