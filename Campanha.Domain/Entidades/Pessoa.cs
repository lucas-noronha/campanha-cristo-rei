using Campanha.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        
        protected string Cpf { get; set; }

        protected string Email { get; set; }

        protected string Contato { get; set; }

        protected string ContatoSecundario { get; set; }

        protected Genero Genero { get; set; }
        //Endereco
        protected string Bairro { get; set; }

        protected string Logradouro { get; set; }

        protected string Numero { get; set; }

        protected string Cep { get; set; }


        //InformacoesAdicionais
        protected string GrupoPastoral { get; set; }

        protected string HorarioDisponivel { get; set; }

        protected string AtividadeDoProjeto { get; set; }

        #region Encapsulamento
        public string GetNome()
        {
            return Nome;
        }
        public string GetCpf()
        {
            return Cpf;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetContato()
        {
            return Contato;
        }
        public string GetContatoSecundario()
        {
            return ContatoSecundario;
        }
        public Genero GetGenero()
        {
            return Genero;
        }
        public string GetBairro()
        {
            return Bairro;
        }
        public string GetLogradouro()
        {
            return Logradouro;
        }
        public string GetNumero()
        {
            return Numero;
        }
        public string GetCep()
        {
            return Cep;
        }
        public string GetGrupoPastoral()
        {
            return GrupoPastoral;
        }
        public string GetHorarioDisponivel()
        {
            return HorarioDisponivel;
        }
        public string GetAtividadeDoProjeto()
        {
            return AtividadeDoProjeto;
        }

        // Métodos Setters
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public void SetContato(string contato)
        {
            Contato = contato;
        }
        public void SetContatoSecundario(string contatoSecundario)
        {
            ContatoSecundario = contatoSecundario;
        }
        public void SetGenero(Genero genero)
        {
            Genero = genero;
        }
        public void SetBairro(string bairro)
        {
            Bairro = bairro;
        }
        public void SetLogradouro(string logradouro)
        {
            Logradouro = logradouro;
        }
        public void SetNumero(string numero)
        {
            Numero = numero;
        }
        public void SetCep(string cep)
        {
            Cep = cep;
        }
        public void SetGrupoPastoral(string grupoPastoral)
        {
            GrupoPastoral = grupoPastoral;
        }
        public void SetHorarioDisponivel(string horarioDisponivel)
        {
            HorarioDisponivel = horarioDisponivel;
        }
        public void SetAtividadeDoProjeto(string atividadeDoProjeto)
        {
            AtividadeDoProjeto = atividadeDoProjeto;
        }
        #endregion
        #region ParaMapeamentoContexto
        public static string GetNameOfNome()
        {
            return nameof(Nome);
        }

        public static string GetNameOfCpf()
        {
            return nameof(Cpf);
        }

        public static string GetNameOfEmail()
        {
            return nameof(Email);
        }

        public static string GetNameOfContato()
        {
            return nameof(Contato);
        }

        public static string GetNameOfContatoSecundario()
        {
            return nameof(ContatoSecundario);
        }

        public static string GetNameOfGenero()
        {
            return nameof(Genero);
        }

        public static string GetNameOfBairro()
        {
            return nameof(Bairro);
        }

        public static string GetNameOfLogradouro()
        {
            return nameof(Logradouro);
        }

        public static string GetNameOfNumero()
        {
            return nameof(Numero);
        }

        public static string GetNameOfCep()
        {
            return nameof(Cep);
        }

        public static string GetNameOfGrupoPastoral()
        {
            return nameof(GrupoPastoral);
        }

        public static string GetNameOfHorarioDisponivel()
        {
            return nameof(HorarioDisponivel);
        }

        public static string GetNameOfAtividadeDoProjeto()
        {
            return nameof(AtividadeDoProjeto);
        }
        #endregion
    }
}
