using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using PruebaTecnicaCrud.Api.Core.Services;
using PruebaTecnicaCrud.Api.Infrastructure.Repositories;
using Shop.Api.Core.Interfaces;
using Shop.Api.Infrastructure.Context;
using Shop.Api.Infrastructure.Filters;
using Shop.Api.Infrastructure.Mappers;
using Shop.Api.Infrastructure.Repositories;
using System;

namespace Shop.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup),typeof(AutomapperProfile));

            services.AddDbContext<AppShopDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionDefault"), x => x.MigrationsAssembly("Shop.Api.Infrastructure")));

            services.AddControllers(options => 
            {
                options.Filters.Add<GlobalValidationFilterAttribute>();
            }).AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shop.Api", Version = "v1" });
            });

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Shop.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
