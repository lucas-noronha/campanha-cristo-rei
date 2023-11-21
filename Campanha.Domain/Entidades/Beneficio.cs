using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class Beneficio
    {
        public Beneficio(string nome, string descricao)
        {
            SetNome(nome);
            SetDescricao(descricao);
        }
        private int Id { get; set; }

        private string Nome { get; set; }

        private string Descricao { get; set; }
        private ICollection<BeneficioxFamilia> Familias => new List<BeneficioxFamilia>();

        #region Encapsulamento
        public int GetId()
        {
            return Id;
        }
        
        public string GetNome()
        {
            return Nome;
        }        
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            this.Descricao = descricao;
        }
        #endregion


        #region ParaMapeamentoContexto
        public static string GetNameOfId()
        {
            return nameof(Id);
        }
        public static string GetNameOfNome()
        {
            return nameof(Nome);
        }
        public static string GetNameOfDescricao()
        {
            return nameof(Descricao);
        }

        public static string GetNameOfFamilias()
        {
            return nameof(Familias);
        }
        #endregion

    }
}
