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
    internal class BeneficioFamiliarConfig : IEntityTypeConfiguration<BeneficioxFamilia>
    {
        public void Configure(EntityTypeBuilder<BeneficioxFamilia> builder)
        {
            builder
                .ToTable("beneficios_por_familia");

            builder.HasKey(BeneficioxFamilia.GetNameOfFamiliaId(), BeneficioxFamilia.GetNameOfBeneficioId(), BeneficioxFamilia.GetNameOfOpcaoBeneficio());

            builder
                .Property(BeneficioxFamilia.GetNameOfFamiliaId())
                .HasColumnName("familia_id");

            builder
                .Property(BeneficioxFamilia.GetNameOfBeneficioId())
                .HasColumnName("beneficio_id");

            builder
                .Property(BeneficioxFamilia.GetNameOfOpcaoBeneficio())
                .HasColumnName("opcao_beneficio");

            builder
                .Property(BeneficioxFamilia.GetNameOfDataInicioBeneficiamento())
                .HasColumnName("data_inicio");

            builder
                .Property(BeneficioxFamilia.GetNameOfDataFinalizacaoBeneficiamento())
                .HasColumnName("data_finalizacao");

            builder
                .HasOne(BeneficioxFamilia.GetNameOfFamilia())
                .WithMany(Familia.GetNameOfBeneficios());



        }
    }
}
