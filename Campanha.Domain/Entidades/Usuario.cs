using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class Usuario : Pessoa
    {
        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }
        private int Id { get; set; }

        private string Cargo { get; set; }

        private string Login { get; set; }

        private string Senha { get; set; }

        private int? EquipeId { get; set; }
        private Equipe Equipe { get; set; }

        private bool Ativo { get; set; }

        #region Encapsulamento
        public int GetId() { return Id; }
        public string GetCargo() { return Cargo; }
        public string GetLogin() { return Login; }
        public string GetSenha() { return Senha; }
        public int? GetEquipeId() { return EquipeId; }
        public Equipe GetEquipe() { return Equipe; }
        public bool GetAtivo() { return Ativo; }

        public void SetCargo(string cargo) { Cargo = cargo; }
        public void SetLogin(string login) { Login = login; }
        public void SetSenha(string senha) { Senha = senha; }
        public void SetEquipeId(int? equipeId) { EquipeId = equipeId; }
        public void SetEquipe(Equipe equipe) { Equipe = equipe; }
        public void SetAtivo(bool ativo) { Ativo = ativo; }

        #endregion

        #region ParaMapemantoContexto
        public static string GetNameOfId() { return nameof(Id); }
        public static string GetNameOfCargo() { return nameof(Cargo); }
        public static string GetNameOfLogin() { return nameof(Login); }
        public static string GetNameOfSenha() { return nameof(Senha); }
        public static string GetNameOfEquipeId() { return nameof(EquipeId); }
        public static string GetNameOfEquipe() { return nameof(Equipe); }
        public static string GetNameOfAtivo() { return nameof(Ativo); }

        #endregion
    }
}
