using Campanha.Domain.Dtos;
using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Servicos
{
    public class EquipeServico : EntidadeServicoPadrao<Equipe, EquipeDto>
    {
        public EquipeServico(IEquipeRepositorio repo) : base(repo)
        {

        }
        public List<UsuarioDto> BuscarUsuariosDaEquipe(int id)
        {
            var repo = (IEquipeRepositorio)_repo;
            var usuarios = repo.BuscarUsuariosDaEquipe(id);
            return usuarios.Select(x => UsuarioDto.CriarDto(x)).ToList();
        }

        public List<VoluntarioDto> BuscarVoluntariosParaEquipe(int id)
        {
            var repo = (IEquipeRepositorio)_repo;
            var voluntarios = repo.BuscarVoluntariosParaEquipe(id);
            return voluntarios.Select(x => VoluntarioDto.CriarDto(x)).ToList();
        }


    }
}
