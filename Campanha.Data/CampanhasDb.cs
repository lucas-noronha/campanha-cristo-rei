using Campanha.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data
{
    public class CampanhasDb : DbContext
    {
        public CampanhasDb(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<BeneficioxFamilia> BeneficioFamiliar { get; set; }
        public DbSet<CadastroDeCampanha> Campanhas { get; set; }

        public DbSet<Equipe> Equipes { get; set; }

        public DbSet<Familia> Familias { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Voluntario> Voluntarios { get; set; }


    }
}
