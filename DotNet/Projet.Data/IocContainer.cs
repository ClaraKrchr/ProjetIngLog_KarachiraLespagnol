namespace Projet.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class IocContainer
    {
        public static void ConfigureContainer(IServiceCollection collection, IConfiguration configuration)
        {
            ConfigureInfrastructureDataContainer(collection, configuration);
            ConfigureApplicationContainer(collection);
        }

        private static void ConfigureApplicationContainer(IServiceCollection collection)
        {
        }

        private static void ConfigureInfrastructureDataContainer(IServiceCollection collection, IConfiguration configuration)
        {
            collection.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Database"));
                options.EnableSensitiveDataLogging();
            });
        }
    }
}
