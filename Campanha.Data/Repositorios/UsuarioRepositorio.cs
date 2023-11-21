using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces.IRepositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioPadrao<Usuario>, IUsuarioRepositorio
    {
        private readonly CampanhasDb Db;
        public UsuarioRepositorio(CampanhasDb db) : base(db)
        {
            Db = db;
        }

        public override Usuario BuscarPorId(int id)
        {
            Usuario usuario = Db.Usuarios.Include(Usuario.GetNameOfEquipe()).FirstOrDefault(x => x.GetId() == id);
            return usuario;
        }
    }
}
