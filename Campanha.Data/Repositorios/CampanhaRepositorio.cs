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
    public class CampanhaRepositorio : RepositorioPadrao<CadastroDeCampanha>, ICampanhaRepositorio
    {
        private readonly CampanhasDb Db;
        public CampanhaRepositorio(CampanhasDb db) : base(db)
        {
            Db = db;    
        }

        public List<Familia> BuscarFamiliasNaCampanha(int id)
        {
            CadastroDeCampanha campanha = Db.Campanhas.Include(CadastroDeCampanha.GetNameOfFamilias()).FirstOrDefault(x => x.GetId() == id);
            return campanha.GetFamilias().ToList();
        }

        public override CadastroDeCampanha BuscarPorId(int id)
        {
            return Db.Campanhas.Include(CadastroDeCampanha.GetNameOfFamilias()).FirstOrDefault(x => x.GetId() == id);
        }
    }
}
