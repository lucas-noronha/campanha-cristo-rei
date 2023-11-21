using Campanha.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Interfaces.IRepositorios
{
    public interface IFamiliaRepositorio : IRepositorioPadrao<Familia>
    {
        public void RemoverBeneficioRecebido(int familiaId, int beneficioId);
        public void RemoverBeneficioDeInteresse(int familiaId, int beneficioId);

        public void AdicionarBeneficioDeInteresse(BeneficioxFamilia beneficio);
        public void AdicionarBeneficioRecebido(BeneficioxFamilia beneficio);
        public void FinalizarBeneficioRecebido(int familiaId, int beneficioId, DateTime data);
    }
}
