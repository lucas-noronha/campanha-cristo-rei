using Campanha.Domain.Interfaces;
using Campanha.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Servicos
{
    public class EntidadeServicoPadrao<T, Dto> : IService<T, Dto> where T : class where Dto : TDto<T, Dto>
    {
        public readonly IRepositorioPadrao<T> _repo;
        public EntidadeServicoPadrao(IRepositorioPadrao<T> repo)
        {
            _repo = repo;
        }
        public Dto ObterPorId(int id)
        {
            var entidade = _repo.BuscarPorId(id);
            var dto = TDto<T, Dto>.CriarDto(entidade);
            return dto;
        }
        public bool AdicionarRegistro(Dto dto)
        {
            var entidade = dto.CriarOuAlterarEntidade();
            return _repo.Add(entidade);            
        }

        public Dto EditarRegistro(Dto dto)
        {
            var entidade = this.ObterEntidadePorId(dto.Id);
            dto.CriarOuAlterarEntidade(entidade);
            _repo.Editar(entidade);
            return TDto<T, Dto>.CriarDto(entidade);
            
        }

        public bool ExcluirRegistro(int id)
        {
            var entidade = ObterEntidadePorId(id);
            _repo.Excluir(entidade);
            return true;
        }

        public List<Dto> ObterLista(Expression<Func<T, bool>> linqFiltro)
        {
            var entidades = _repo.BuscarLista(linqFiltro);
            var dtos = entidades.Select(x => TDto<T, Dto>.CriarDto(x));
            return dtos.ToList();
        }

        protected T ObterEntidadePorId(int id)
        {
            var entidade = _repo.BuscarPorId(id);
            return entidade;
        }
    }
}
