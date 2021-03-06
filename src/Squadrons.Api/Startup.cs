using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Squadrons.Bll.Interfaces;
using Squadrons.Bll.Services;
using Squadrons.Dal;
using Squadrons.Dal.Repositories;
using Squadrons.Model.Interfaces;

namespace Squadrons.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<SquadronsTestingDbContext>(options =>
            {
                options.UseInMemoryDatabase("Squadrons");
            });

            services.AddScoped<ISquadronsService, SquadronsService>();
            services.AddScoped<ISquadronsRepository, SquadronsRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Squadrons Testing API",
                    Description = "A simple example ASP.NET Core Testing",
                    Contact = new OpenApiContact
                    {
                        Name = "D�vid Bertalan",
                        Email = string.Empty,
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Squadrons Testing API");
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
