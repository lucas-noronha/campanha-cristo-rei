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
    public class UsuarioServico : EntidadeServicoPadrao<Usuario, UsuarioDto>
    {
        public UsuarioServico(IUsuarioRepositorio repo) : base(repo)
        {
        }


    }
}
