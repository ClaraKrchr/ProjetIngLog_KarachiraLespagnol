using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Projet
{
    public class Program
    {
        public static HostBuilderContext hostContext;
        public static IServiceCollection services;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            .ConfigureServices((hostContext, services) =>
            {
                ConfigureServices(services);
            });


        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
        }
    }
}
