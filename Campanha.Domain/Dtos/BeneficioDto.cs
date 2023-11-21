using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class BeneficioDto : TDto<Beneficio, BeneficioDto>
    {
        public BeneficioDto()
        {}
        public BeneficioDto(Beneficio entidade)
        {
            this.Id = entidade.GetId();
            this.Nome = entidade.GetNome();
            this.Descricao = entidade.GetDescricao();
        }

        
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public static BeneficioDto CriarDto(Beneficio entidade)
        {
            return new BeneficioDto(entidade);
        }

        public Beneficio CriarOuAlterarEntidade(Beneficio referencia = null)
        {
            var entidade = referencia;

            if (entidade == null)
            {
                entidade = new Beneficio(this.Nome, this.Descricao);
            }

            entidade.SetNome(this.Nome);
            entidade.SetDescricao(this.Descricao);

            return entidade;
        }

        
    }
}
