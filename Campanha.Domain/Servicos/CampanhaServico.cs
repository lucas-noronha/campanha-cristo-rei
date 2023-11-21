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
    public class CampanhaServico : EntidadeServicoPadrao<CadastroDeCampanha, CampanhaDto>
    {
        
        public CampanhaServico(ICampanhaRepositorio repo) : base(repo)
        {
        }

        public List<FamiliaDto> BuscarFamiliasNaCampanha(int campanhaId)
        {
            var familiasNaCampanha = ((ICampanhaRepositorio)_repo).BuscarFamiliasNaCampanha(campanhaId);

            return familiasNaCampanha.Select(x => FamiliaDto.CriarDto(x)).ToList();

        }
    }
}
