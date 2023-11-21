using Campanha.Domain.Entidades;
using Campanha.Domain.Enums;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class PessoaDto : TDto<Pessoa, PessoaDto>
    {
        public PessoaDto(Pessoa entidade)
        {
            Nome = entidade.GetNome();
            Cpf = entidade.GetCpf();
            Email = entidade.GetEmail();
            Contato = entidade.GetContato();
            ContatoSecundario = entidade.GetContatoSecundario();
            Genero = entidade.GetGenero();

            Bairro = entidade.GetBairro();
            Logradouro = entidade.GetLogradouro();
            Numero = entidade.GetNumero();
            Cep = entidade.GetCep();

            GrupoPastoral = entidade.GetGrupoPastoral();
            HorarioDisponivel = entidade.GetHorarioDisponivel();
            AtividadeDoProjeto = entidade.GetAtividadeDoProjeto();
        }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string ContatoSecundario { get; set; }
        public Genero Genero { get; set; }

        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }

        public string GrupoPastoral { get; set; }
        public string HorarioDisponivel { get; set; }
        public string AtividadeDoProjeto { get; set; }

        public Pessoa CriarOuAlterarEntidade(Pessoa pessoa)
        {
            var entidade = pessoa;
            
            entidade.SetNome(Nome);
            entidade.SetCpf(Cpf);
            entidade.SetEmail(Email);
            entidade.SetContato(Contato);
            entidade.SetContatoSecundario(ContatoSecundario);
            entidade.SetGenero(Genero);

            entidade.SetBairro(Bairro);
            entidade.SetLogradouro(Logradouro);
            entidade.SetNumero(Numero);
            entidade.SetCep(Cep);

            entidade.SetGrupoPastoral(GrupoPastoral);
            entidade.SetHorarioDisponivel(HorarioDisponivel);
            entidade.SetAtividadeDoProjeto(AtividadeDoProjeto);

            return entidade;
        }
    }
}
