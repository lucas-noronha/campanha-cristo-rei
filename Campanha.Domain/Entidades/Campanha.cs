using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class CadastroDeCampanha
    {
        public CadastroDeCampanha(string nomeCampanha, DateTime dataInicio)
        {
            SetNomeCampanha(nomeCampanha);
            SetDataInicio(dataInicio);
        }
        private int Id { get; set; }

        private string NomeCampanha { get; set; }

        private DateTime DataInicio { get; set; }

        private DateTime? DataFinalizacao { get; set; }

        private ICollection<Familia> Familias => new List<Familia>();


        #region Encapsulamento
        public int GetId()
        {
            return Id;
        }

        public string GetNomeCampanha()
        {
            return NomeCampanha;
        }

        public void SetNomeCampanha(string nome)
        {
            this.NomeCampanha = nome;
        }
        public DateTime GetDataInicio()
        {
            return DataInicio;
        }

        public void SetDataInicio(DateTime data)
        {
            this.DataInicio = data;
        }

        public DateTime? GetDataFinalizacao()
        {
            return DataFinalizacao;
        }

        public void SetDataFinalizacao(DateTime? data)
        {
            this.DataFinalizacao = data;
        }

        public List<Familia> GetFamilias()
        {
            return this.Familias.ToList();
        }
        #endregion


        #region ParaMapeamentoContexto
        public static string GetNameOfId()
        {
            return nameof(Id);
        }
        public static string GetNameOfNomeCampanha()
        {
            return nameof(NomeCampanha);
        }
        public static string GetNameOfDataInicio()
        {
            return nameof(DataInicio);
        }
        public static string GetNameOfDataFinalizacao()
        {
            return nameof(DataFinalizacao);
        }
        public static string GetNameOfFamilias()
        {
            return nameof(Familias);
        }
        #endregion



    }
}
