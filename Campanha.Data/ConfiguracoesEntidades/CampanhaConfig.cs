using Campanha.Domain.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data.ConfiguracoesEntidades
{
    internal class CampanhaConfig : IEntityTypeConfiguration<Domain.Entidades.CadastroDeCampanha>
    {
        public void Configure(EntityTypeBuilder<Domain.Entidades.CadastroDeCampanha> builder)
        {
            builder
                .ToTable("campanha");

            builder.HasKey(CadastroDeCampanha.GetNameOfId());

            builder
                .Property(CadastroDeCampanha.GetNameOfId())
                .HasColumnName("id")
                .UseSerialColumn();

            builder
                .Property(CadastroDeCampanha.GetNameOfNomeCampanha())
                .HasColumnName("nome");

            builder
                .Property(CadastroDeCampanha.GetNameOfDataInicio())
                .HasColumnName("data_inicio");

            builder
                .Property(CadastroDeCampanha.GetNameOfDataFinalizacao())
                .HasColumnName("data_finalizacao");

            builder
                .HasMany(CadastroDeCampanha.GetNameOfFamilias())
                .WithOne(Familia.GetNameOfCampanha());
        }
    }
}
