using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Projet.Business.Services;
using Projet.Data.Repositories;

namespace Projet
{
    public class Startup
    {
        readonly string MyallowSpecificOrigins = "_myAllowSpecificOrigins";

        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(options =>
            //{
            //    options.AddPolicy(name: MyallowSpecificOrigins,
            //        builder =>
            //        {
            //            builder.WithOrigins("*", "*").AllowAnyHeader().AllowAnyMethod();
            //        });
            //});

            services.AddCors();

            services.AddDbContext<DataContext>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IFactureService, FactureService>();
            services.AddTransient<IFactureRepository, FactureRepository>();
            services.AddTransient<IProduitService, ProduitService>();
            services.AddTransient<IProduitRepository, ProduitRepository>();
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            // app.UseCors(MyallowSpecificOrigins);

            //app.UseCors(x => x
            //        .WithOrigins(MyallowSpecificOrigins)
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowCredentials());

            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
