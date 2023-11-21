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
    public class VoluntarioRepositorio : RepositorioPadrao<Voluntario>, IVoluntarioRepositorio
    {
        private readonly CampanhasDb Db;
        public VoluntarioRepositorio(CampanhasDb db) : base(db)
        {
            Db = db;
        }

        public override Voluntario BuscarPorId(int id)
        {
            Voluntario voluntario = Db.Voluntarios.Include(Voluntario.GetNameOfEquipeDeInteresse()).FirstOrDefault(x => x.GetId() == id);
            return voluntario;
        }
    }
}
