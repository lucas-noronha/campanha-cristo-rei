using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Dtos
{
    public  class EquipeDto : TDto<Equipe, EquipeDto>
    {
        public EquipeDto()
        {}
        public EquipeDto(Equipe equipe)
        {
            this.Id = equipe.GetId();
            this.Nome = equipe.GetNome();
            this.Descricao = equipe.GetDescricao();

            if (equipe.GetMembros().Any())
            {
                this.Membros = equipe.GetMembros().Select(x => UsuarioDto.CriarDto(x)).ToList();
            }
            if (equipe.GetVoluntarios().Any())
            {
                this.Voluntarios = equipe.GetVoluntarios().Select(x => VoluntarioDto.CriarDto(x)).ToList();
            }
        }
        public int? Id { get; set; }

        public string Descricao { get; set; }

        public string Nome { get; set; }

        public List<UsuarioDto> Membros { get; set; }
        public List<VoluntarioDto> Voluntarios { get; set; }
        public Equipe CriarOuAlterarEntidade(Equipe equipe = null)
        {
            var entidade = equipe;

            if (entidade == null)
            {
                entidade = new Equipe(this.Descricao, this.Nome);
            }

            entidade.SetDescricao(Descricao);
            entidade.SetNome(Nome);
            return entidade;
        }

        public static EquipeDto CriarDto(Equipe equipe)
        {
            return new EquipeDto(equipe);
        }
    }
}
