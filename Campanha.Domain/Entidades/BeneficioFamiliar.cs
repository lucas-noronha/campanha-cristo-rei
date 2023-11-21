using Campanha.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Entidades
{
    public class BeneficioxFamilia
    {

        private int FamiliaId { get; set; }
        private Familia Familia { get; set; }

        private int BeneficioId { get; set; }
        private Beneficio Beneficio { get; set; }

        private TipoBeneficio OpcaoBeneficio { get; set; }

        private DateTime? DataInicioBeneficiamento { get; set; }

        private DateTime? DataFinalizacaoBeneficiamento { get; set; }

        #region Encapsulamento
        public TipoBeneficio GetOpcaoBeneficio()
        {
            return OpcaoBeneficio;
        }
        public void SetOpcaoBeneficio(TipoBeneficio opcao)
        {
            OpcaoBeneficio = opcao;
        }
        public int GetFamiliaId()
        {
            return FamiliaId;
        }
        public void SetFamiliaId(int familiaId)
        {
            this.FamiliaId = familiaId;
        }
        public Familia GetFamilia()
        {
            return Familia;
        }
        public void SetFamilia(Familia familia)
        {
            this.Familia = familia;
        }
        public int GetBeneficioId()
        {
            return BeneficioId;
        }
        public void SetBeneficioId(int beneficioId)
        {
            this.BeneficioId = beneficioId;
        }
        public Beneficio GetBeneficio()
        {
            return Beneficio;
        }
        public void SetBeneficio(Beneficio beneficio)
        {
            this.Beneficio = beneficio;
        }
        public DateTime? GetDataInicioBeneficiamento()
        {
            return DataInicioBeneficiamento;
        }
        public void SetDataInicioBeneficiamento(DateTime? dataInicio)
        {
            this.DataInicioBeneficiamento = dataInicio;
        }
        public DateTime? GetDataFinalizacaoBeneficiamento()
        {
            return DataFinalizacaoBeneficiamento;
        }
        public void SetDataFinalizacaoBeneficiamento(DateTime? dataFinalizacao)
        {
            this.DataFinalizacaoBeneficiamento = dataFinalizacao;
        }
        #endregion


        #region ParaMapeamentoContexto
        public static string GetNameOfFamiliaId()
        {
            return nameof(FamiliaId);
        }
        public static string GetNameOfBeneficioId()
        {
            return nameof(BeneficioId);
        }
        public static string GetNameOfOpcaoBeneficio()
        {
            return nameof(OpcaoBeneficio);
        }
        public static string GetNameOfDataInicioBeneficiamento()
        {
            return nameof(DataInicioBeneficiamento);
        }
        public static string GetNameOfDataFinalizacaoBeneficiamento()
        {
            return nameof(DataFinalizacaoBeneficiamento);
        }
        public static string GetNameOfFamilia()
        {
            return nameof(Familia);
        }
        public static string GetNameOfBeneficio()
        {
            return nameof(Beneficio);
        }
        #endregion
    }
}
