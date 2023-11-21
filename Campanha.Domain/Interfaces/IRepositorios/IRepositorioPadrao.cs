using Campanha.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Interfaces.IRepositorios
{
    public interface IRepositorioPadrao<T> where T : class
    {
        T BuscarPorId(int id);

        List<T> BuscarLista(Expression<Func<T, bool>> linqFiltro);

        bool Add(T entidade);

        bool AddRange(ICollection<T> range);

        void Editar(T entidade);

        void Excluir(T entidade);
    }
}
