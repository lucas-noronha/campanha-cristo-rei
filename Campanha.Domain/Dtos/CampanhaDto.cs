using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class CampanhaDto : TDto<CadastroDeCampanha, CampanhaDto>
    {
        public CampanhaDto()
        {}

        public CampanhaDto(CadastroDeCampanha campanha)
        {
            this.NomeCampanha = campanha.GetNomeCampanha();
            this.DataInicio = campanha.GetDataInicio();
            this.DataFinalizacao = campanha.GetDataFinalizacao();

            if (campanha.GetFamilias().Any())
            {
                this.Familias = campanha.GetFamilias().Select(x => FamiliaDto.CriarDto(x)).ToList();
            }
        }

        public int? Id { get; set; }

        public string NomeCampanha { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime? DataFinalizacao { get; set; }

        public ICollection<FamiliaDto> Familias { get; set; }

        public CadastroDeCampanha CriarOuAlterarEntidade(CadastroDeCampanha entidade = null)
        {
            var campanha = entidade;

            if (campanha == null)
            {
                campanha = new CadastroDeCampanha(this.NomeCampanha, this.DataInicio);
            }

            campanha.SetNomeCampanha(this.NomeCampanha);
            campanha.SetDataInicio(this.DataInicio);
            campanha.SetDataFinalizacao(this.DataFinalizacao);
            return campanha;

        }

        public static CampanhaDto CriarDto(CadastroDeCampanha cadastroDeCampanha)
        {
            return new CampanhaDto(cadastroDeCampanha);
        }
    }
}
