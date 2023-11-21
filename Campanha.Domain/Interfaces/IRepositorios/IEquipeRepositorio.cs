using Campanha.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Interfaces.IRepositorios
{
    public interface IEquipeRepositorio : IRepositorioPadrao<Equipe>
    {
        List<Usuario> BuscarUsuariosDaEquipe(int id);

        List<Voluntario> BuscarVoluntariosParaEquipe(int id);
    }
}
