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
    public class EquipeRepositorio : RepositorioPadrao<Equipe>, IEquipeRepositorio
    {
        private readonly CampanhasDb Db;
        public EquipeRepositorio(CampanhasDb db) : base(db)
        {
            Db = db;
        }
        public override Equipe BuscarPorId(int id)
        {
            Equipe equipe = Db.Equipes.Include(Equipe.GetNameOfMembros()).Include(Equipe.GetNameOfVoluntarios()).FirstOrDefault(x => x.GetId() == id);
            return equipe;
        }

        public List<Usuario> BuscarUsuariosDaEquipe(int id)
        {
            List<Usuario> usuarios = Db.Equipes
                .Include(Equipe.GetNameOfMembros())
                .FirstOrDefault(x => x.GetId() == id).GetMembros()
                .ToList();
            return usuarios;
        }

        public List<Voluntario> BuscarVoluntariosParaEquipe(int id)
        {
            var equipe = Db.Equipes.Include(Voluntario.GetNameOfEquipeDeInteresse()).FirstOrDefault(x => x.GetId() == id);
            List<Voluntario> voluntarios = equipe.GetVoluntarios().ToList();
            return voluntarios;
        }
    }
}
