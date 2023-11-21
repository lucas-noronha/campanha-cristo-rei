using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Campanha.Domain.Entidades;

namespace Campanha.Data.ConfiguracoesEntidades
{
    internal class FamiliaConfig : IEntityTypeConfiguration<Domain.Entidades.Familia>
    {
        public void Configure(EntityTypeBuilder<Familia> builder)
        {
            builder
                .ToTable("familia");

            builder.HasKey(Familia.GetNameOfId());

            builder
                .Property(Familia.GetNameOfId())
                .HasColumnName("id")
                .UseSerialColumn();

            builder
                .Property(Familia.GetNameOfNome())
                .HasColumnName("nome");

            builder
                .Property(Familia.GetNameOfNit())
                .HasColumnName("nit");

            builder
                .Property(Familia.GetNameOfGenero())
                .HasColumnName("genero");

            builder
                .Property(Familia.GetNameOfCpf())
                .HasColumnName("cpf");

            builder
                .Property(Familia.GetNameOfBairro())
                .HasColumnName("bairro");

            builder
                .Property(Familia.GetNameOfLogradouro())
                .HasColumnName("logradouro");

            builder
                .Property(Familia.GetNameOfNumeroEndereco())
                .HasColumnName("numero");

            builder
                .Property(Familia.GetNameOfCep())
                .HasColumnName("cep");

            builder
                .Property(Familia.GetNameOfCelular())
                .HasColumnName("celular");

            builder
                .Property(Familia.GetNameOfTelefoneFixo())
                .HasColumnName("tel_fixo");

            builder
                .Property(Familia.GetNameOfQtdePessoas())
                .HasColumnName("qtde_pessoas");

            builder
                .Property(Familia.GetNameOfRendaTotalEstimada())
                .HasColumnName("renda_familiar_estimada");

            builder
                .Property(Familia.GetNameOfPossuiFilhos())
                .HasColumnName("possui_filhos");

            builder
                .Property(Familia.GetNameOfFrequentaIgreja())
                .HasColumnName("frequenta_igreja");

            builder
                .Property(Familia.GetNameOfPertenceGrupoOracao())
                .HasColumnName("pertence_grupo_oracao");

            builder
                .Property(Familia.GetNameOfIgrejaFrequentada())
                .HasColumnName("igreja_frequentada");

            builder
                .Property(Familia.GetNameOfGrupoOracao())
                .HasColumnName("grupo_oracao");

            builder
                .Property(Familia.GetNameOfReceberPessoasEmCasa())
                .HasColumnName("recebe_pessoas");

            builder
                .Property(Familia.GetNameOfDiasParaReceberPessoas())
                .HasColumnName("dias_receber_pessoas");

            builder
                .Property(Familia.GetNameOfCampanhaId())
                .HasColumnName("codigo_campanha");


            //builder
            //    .HasMany(typeof(BeneficioxFamilia),Familia.GetNameOfBeneficiosDeInteresse())
            //    .WithOne(BeneficioxFamilia.GetNameOfFamiliaId());
        }
    }
}
