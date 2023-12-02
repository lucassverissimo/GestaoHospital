using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using GestaoHospital.WebAPI.Data;
using GestaoHospital.WebAPI.Data.Repositories.Mapas;
using GestaoHospital.WebAPI.Data.Repositories.Usuarios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GestaoHospital.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GHContext>(
                context => context.UseMySql(Configuration.GetConnectionString("MySqlConnection"))
            );

            services
                .AddControllers()
                .AddNewtonsoftJson(
                    opt =>
                        opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft
                            .Json
                            .ReferenceLoopHandling
                            .Ignore
                );

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IRepositoryMapa, RepositoryMapa>();
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            services.AddScoped<IRepositoryPerfil, RepositoryPerfil>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "V1",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Gestão Hospitalar API",
                        Version = "V1", //description.ApiVersion.ToString(),
                        TermsOfService = new Uri("http://SeusTermosDeUso.com"),
                        Description = "Mantém todo o backend da gestão hospitalar",
                        License = new Microsoft.OpenApi.Models.OpenApiLicense
                        {
                            Name = "Gestão Hospitalar License",
                            Url = new Uri("http://mit.com")
                        },
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Lucas Veríssimo",
                            Email = "lucass.verissimo@gmail.com",
                            Url = new Uri("http://instagram.com/lucassverissimo")
                        }
                    }
                );

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                options.IncludeXmlComments(xmlCommentsFullPath);
            });
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint($"/swagger/V1/swagger.json", "GH - V1");

                    options.RoutePrefix = "";
                });

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
