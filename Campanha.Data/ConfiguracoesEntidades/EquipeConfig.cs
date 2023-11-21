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
    internal class EquipeConfig : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Domain.Entidades.Equipe> builder)
        {
            builder
                .ToTable("equipe");

            builder.HasKey(Equipe.GetNameOfId());

            builder
                .Property(Equipe.GetNameOfId())
                .HasColumnName("id")
                .UseSerialColumn();

            builder
                .Property(Equipe.GetNameOfNome())
                .HasColumnName("nome");

            builder
                .Property(Equipe.GetNameOfDescricao())
                .HasColumnName("descricao");

            builder
                .HasMany(Equipe.GetNameOfMembros())
                .WithOne(Usuario.GetNameOfEquipe());

            builder
                .HasMany(Equipe.GetNameOfVoluntarios())
                .WithOne(Voluntario.GetNameOfEquipeDeInteresse());
        }
    }
}
