namespace API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(
                this IServiceCollection services
            )
        {
            //services.AddScoped<IRepository, Repository>;
            return services;
        }
    }
}
