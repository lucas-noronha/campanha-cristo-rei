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
    internal class VoluntarioConfig : IEntityTypeConfiguration<Voluntario>
    {
        public void Configure(EntityTypeBuilder<Voluntario> builder)
        {
            builder
                .HasKey(Voluntario.GetNameOfId());

            PessoaConfigHelper.Configure(builder, "voluntario", "public");

            builder
                .Property(Voluntario.GetNameOfId())
                .HasColumnName("id");
            builder
                .Property(Voluntario.GetNameOfEquipeDeInteresseId())
                .HasColumnName("equipe_interesse_id");

            builder
                .HasOne(Voluntario.GetNameOfEquipeDeInteresse())
                .WithMany(Equipe.GetNameOfVoluntarios());
        }
    }
}
