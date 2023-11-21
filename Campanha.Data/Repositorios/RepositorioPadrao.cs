using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Data.Repositorios
{
    public abstract class RepositorioPadrao<T> : IRepositorioPadrao<T> where T : class
    {
        private readonly CampanhasDb Db;
        public RepositorioPadrao(CampanhasDb db)
        {
            Db = db;    
        }
        public bool Add(T entidade)
        {
            Db.Set<T>().Add(entidade);
            Db.SaveChanges();

            return true;
        }

        public bool AddRange(ICollection<T> range)
        {

            Db.Set<T>().AddRange(range);
            Db.SaveChanges();
            return true;


        }

        public List<T> BuscarLista(Expression<Func<T, bool>> filtro)
        {
            var query = Db.Set<T>().Where(filtro);
            return query.ToList();
        }

        public abstract T BuscarPorId(int id);

        public void Editar(T entidade)
        {
            Db.Entry(entidade).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
        }

        public void Excluir(T entidade)
        {
            Db.Set<T>().Remove(entidade);
            Db.SaveChanges();
        }
    }
}
