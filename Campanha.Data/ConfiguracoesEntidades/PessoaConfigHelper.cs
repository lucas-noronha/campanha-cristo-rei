using Campanha.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data.ConfiguracoesEntidades
{
    internal class PessoaConfigHelper
    {
        public static void Configure<T>(EntityTypeBuilder<T> builder, string tabela, string schema)
            where T : Pessoa
        {
            builder
                .ToTable(tabela, schema);

            builder
                .Property(Pessoa.GetNameOfNome())
                .HasColumnName("nome");

            builder
                .Property(Pessoa.GetNameOfCpf())
                .HasColumnName("cpf");

            builder
                .Property(Pessoa.GetNameOfGenero())
                .HasColumnName("genero");

            builder
                .Property(Pessoa.GetNameOfEmail())
                .HasColumnName("email");

            builder
                .Property(Pessoa.GetNameOfContato())
                .HasColumnName("contato");

            builder
                .Property(Pessoa.GetNameOfContatoSecundario())
                .HasColumnName("contato_secundario");

            builder
                .Property(Pessoa.GetNameOfBairro())
                .HasColumnName("bairro");

            builder
                .Property(Pessoa.GetNameOfLogradouro())
                .HasColumnName("logradouro");

            builder
                .Property(Pessoa.GetNameOfNumero())
                .HasColumnName("numero");

            builder
                .Property(Pessoa.GetNameOfCep())
                .HasColumnName("cep");

            builder
                .Property(Pessoa.GetNameOfGrupoPastoral())
                .HasColumnName("grupo_pastoral");

            builder
                .Property(Pessoa.GetNameOfHorarioDisponivel())
                .HasColumnName("horario_disponivel");

            builder
                .Property(Pessoa.GetNameOfAtividadeDoProjeto())
                .HasColumnName("atividade_projeto");
        }
    }
}
