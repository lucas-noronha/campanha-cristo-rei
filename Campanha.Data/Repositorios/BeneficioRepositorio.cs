using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data.Repositorios
{
    public class BeneficioRepositorio : RepositorioPadrao<Beneficio>, IBeneficioRepositorio
    {
        private readonly CampanhasDb Db;
        public BeneficioRepositorio(CampanhasDb db) : base(db)
        {
            
            Db = db;
        }

        public override Beneficio BuscarPorId(int id)
        {
            Beneficio beneficio = Db.Beneficios.FirstOrDefault(x => x.GetId() == id);
            return beneficio;
        }
    }
}
