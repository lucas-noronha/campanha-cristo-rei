using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campanha.Domain.Entidades;

namespace Campanha.Data.ConfiguracoesEntidades
{
    internal class BeneficioConfig : IEntityTypeConfiguration<Beneficio>
    {
        public void Configure(EntityTypeBuilder<Beneficio> builder)
        {
            
            builder
                .ToTable("beneficios");

            builder.HasKey(Beneficio.GetNameOfId());

            builder
                .Property(Beneficio.GetNameOfId())
                .HasColumnName("id")
                .UseSerialColumn();

            builder
                .Property(Beneficio.GetNameOfNome())
                .HasColumnName("nome");

            builder
                .Property(Beneficio.GetNameOfDescricao())
                .HasColumnName("descricao");
        }
    }
}
