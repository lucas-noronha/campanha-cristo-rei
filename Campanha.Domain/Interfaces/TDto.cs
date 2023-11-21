using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Interfaces
{
    public interface TDto<T, Dto> where T : class
    {
        public int? Id { get; set; }
        public T CriarOuAlterarEntidade(T entidade = null);
        public static Dto CriarDto(T entidade) => throw new NotImplementedException();
    }
}
