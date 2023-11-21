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
    public class BeneficiosPorFamiliaDto : TDto<BeneficioxFamilia, BeneficiosPorFamiliaDto>
    {
        public BeneficiosPorFamiliaDto(BeneficioxFamilia entidade)
        {
            this.FamiliaId = entidade.GetFamiliaId();
            this.BeneficioId = entidade.GetBeneficioId();
            this.OpcaoBeneficio = entidade.GetOpcaoBeneficio();
            this.DataInicioBeneficiamento = entidade.GetDataInicioBeneficiamento();
            this.DataFinalizacaoBeneficiamento = entidade.GetDataFinalizacaoBeneficiamento();

        }
        public int FamiliaId { get; set; }

        public int BeneficioId { get; set; }

        public TipoBeneficio OpcaoBeneficio { get; set; }

        public DateTime? DataInicioBeneficiamento { get; set; }

        public DateTime? DataFinalizacaoBeneficiamento { get; set; }
        public int? Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BeneficioxFamilia CriarOuAlterarEntidade(BeneficioxFamilia entidade = null)
        {
            var referencia = entidade;

            if (referencia == null)
            {
                referencia = new BeneficioxFamilia();
            }

            referencia.SetBeneficioId(this.BeneficioId);
            referencia.SetFamiliaId(this.FamiliaId);
            referencia.SetOpcaoBeneficio(this.OpcaoBeneficio);
            referencia.SetDataInicioBeneficiamento(this.DataInicioBeneficiamento);
            referencia.SetDataFinalizacaoBeneficiamento(this.DataFinalizacaoBeneficiamento);

            return referencia;
        }

        public static BeneficiosPorFamiliaDto CriarDto(BeneficioxFamilia entidade)
        {
            return new BeneficiosPorFamiliaDto(entidade);
        }
    }
}
