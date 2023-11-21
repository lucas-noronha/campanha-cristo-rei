using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class Equipe
    {
        public Equipe(string descricao, string nome)
        {
            Descricao = descricao;
            Nome = nome;
        }

        private int Id { get; set; }

        private string Descricao { get; set; }

        private string Nome { get; set; }

        private ICollection<Usuario> Membros => new List<Usuario>();

        private ICollection<Voluntario> Voluntarios => new List<Voluntario>();

        #region Encapsulamento
        public int GetId()
        {
            return Id;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descriaco)
        {
            Descricao = descriaco;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public ICollection<Usuario> GetMembros()
        {
            return Membros;
        }
        public ICollection<Voluntario> GetVoluntarios()
        {
            return Voluntarios;
        }
        #endregion

        #region ParaMapeamentoContexto
        public static string GetNameOfId()
        {
            return nameof(Id);
        }
        public static string GetNameOfDescricao()
        {
            return nameof(Descricao);
        }
        public static string GetNameOfNome()
        {
            return nameof(Nome);
        }
        public static string GetNameOfMembros()
        {
            return nameof(Membros);
        }
        public static string GetNameOfVoluntarios()
        {
            return nameof(Voluntarios);
        }
        #endregion
    }
}
