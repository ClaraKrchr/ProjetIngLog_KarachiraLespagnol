namespace Projet.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Projet.Data;

    public static class IocContainer
    {
        public static void ConfigureContainer(IServiceCollection collection, IConfiguration configuration)
        {
/*            BIAIocContainer.ConfigureContainer(collection, configuration);
*/
            ConfigureInfrastructureDataContainer(collection, configuration);
            ConfigureApplicationContainer(collection);
        }

        private static void ConfigureApplicationContainer(IServiceCollection collection)
        {
            /*collection.AddTransient<ISiteAppService, SiteAppService>();
            collection.AddTransient<IMemberAppService, MemberAppService>();
            collection.AddTransient<IRoleAppService, RoleAppService>();
            collection.AddTransient<IUserAppService, UserAppService>();
            collection.AddTransient<IViewAppService, ViewAppService>();
            collection.AddTransient<ISupplierAppService, SupplierAppService>();
            collection.AddTransient<IRelanceAppService, RelanceAppService>();
            collection.AddTransient<IBlockTypeAppService, BlockTypeAppService>();
            collection.AddTransient<ISectorAppService, SectorAppService>();
            collection.AddTransient<IStatusAppService, StatusAppService>();
            collection.AddTransient<IColorAppService, ColorAppService>();*/
        }

        private static void ConfigureInfrastructureDataContainer(IServiceCollection collection, IConfiguration configuration)
        {
            collection.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Database"));
                options.EnableSensitiveDataLogging();
            });
            //collection.AddTransient<DataRepository>();
        }
    }
}
