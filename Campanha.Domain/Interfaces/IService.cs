using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Interfaces
{
    public interface IService<T, Dto> where T : class where Dto : TDto<T, Dto>
    {
        public Dto ObterPorId(int id);

        public List<Dto> ObterLista(Expression<Func<T, bool>> linqFiltro);

        public bool AdicionarRegistro(Dto dto);

        public Dto EditarRegistro(Dto dto);

        public bool ExcluirRegistro(int id);

    }
}
