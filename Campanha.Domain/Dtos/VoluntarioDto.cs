using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public class VoluntarioDto : PessoaDto, TDto<Voluntario, VoluntarioDto>
    {
        public VoluntarioDto(Voluntario entidade) : base(entidade)
        {
            Id = entidade.GetId();
            EquipeDeIntereseId = entidade.GetEquipeDeInteresseId();
            if (entidade.GetEquipeDeInteresse() != null)
            {
                EquipeDeInteresse = EquipeDto.CriarDto(entidade.GetEquipeDeInteresse());
            }
        }

        public int? EquipeDeIntereseId { get; set; }

        public EquipeDto EquipeDeInteresse { get; set; }

        public Voluntario CriarOuAlterarEntidade(Voluntario voluntario = null)
        {
            var entidade = voluntario;
            if (entidade == null)
            {
                entidade = new Voluntario();
            }
            base.CriarOuAlterarEntidade(entidade);
            entidade.SetEquipeDeInteresseId(EquipeDeIntereseId);
            return entidade;
        }

        public static VoluntarioDto CriarDto(Voluntario entidade)
        {
            return new VoluntarioDto(entidade);
        }

    }
}
