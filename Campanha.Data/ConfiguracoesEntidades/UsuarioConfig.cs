using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using Campanha.Domain.Entidades;

namespace Campanha.Data.ConfiguracoesEntidades
{
    internal class UsuarioConfig : IEntityTypeConfiguration<Domain.Entidades.Usuario>
    {
        public void Configure(EntityTypeBuilder<Domain.Entidades.Usuario> builder)
        {
            builder.HasKey(Usuario.GetNameOfId());

            PessoaConfigHelper.Configure(builder, "usuario", "public");

            builder
                .Property(Usuario.GetNameOfId())
                .HasColumnName("id")
                .UseSerialColumn();


            builder
                .Property(Usuario.GetNameOfCargo())
                .HasColumnName("cargo");

            builder
                .Property(Usuario.GetNameOfLogin())
                .HasColumnName("login");

            builder
                .Property(Usuario.GetNameOfSenha())
                .HasColumnName("senha");

            builder
                .Property(Usuario.GetNameOfEquipeId())
                .HasColumnName("equipe_id");

            builder
                .Property(Usuario.GetNameOfAtivo())
                .HasColumnName("ativo");

            builder
                .HasOne(Usuario.GetNameOfEquipe())
                .WithMany(Equipe.GetNameOfMembros());
        }

    }
}
