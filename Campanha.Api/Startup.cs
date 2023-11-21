using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Campanha.Data;
using Campanha.Domain.Servicos;
using Campanha.Domain.Interfaces.IRepositorios;
using Campanha.Data.Repositorios;

namespace Campanha.Api
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

            var conStr = Configuration.GetConnectionString("db-campanha");


            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddDbContext<CampanhasDb>(options =>
            {
                var builder = options.UseNpgsql(conStr);
            });
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


            #region InjecaoDeDependencias
            //Repositórios
            services.AddTransient<IBeneficioRepositorio, BeneficioRepositorio>();
            services.AddTransient<ICampanhaRepositorio, CampanhaRepositorio>();
            services.AddTransient<IEquipeRepositorio, EquipeRepositorio>();
            services.AddTransient<IFamiliaRepositorio, FamiliaRepositorio>();
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IVoluntarioRepositorio, VoluntarioRepositorio>();

            //Serviços
            services.AddTransient<BeneficioServico>();
            services.AddTransient<CampanhaServico>();
            services.AddTransient<EquipeServico>();
            services.AddTransient<FamiliaServico>();
            services.AddTransient<UsuarioServico>();
            services.AddTransient<VoluntarioServico>();
            #endregion


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API do Sistema de Gerenciamento de Campanhas", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Campanha.Api v1"));
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
