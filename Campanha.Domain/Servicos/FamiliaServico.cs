using Campanha.Domain.Dtos;
using Campanha.Domain.Entidades;
using Campanha.Domain.Interfaces.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campanha.Domain.Servicos
{
    public class FamiliaServico : EntidadeServicoPadrao<Familia, FamiliaDto>
    {
        private IFamiliaRepositorio familiaRepositorio;
        public FamiliaServico(IFamiliaRepositorio repo) : base(repo)
        {
            familiaRepositorio = repo;
        }

        public void AdicionarBeneficioDeInteresse(BeneficiosPorFamiliaDto dto)
        {
            var beneficio = dto.CriarOuAlterarEntidade();
            beneficio.SetOpcaoBeneficio(Enums.TipoBeneficio.TemInteresse);
            familiaRepositorio.AdicionarBeneficioDeInteresse(beneficio);

        }

        public void AdicionarBeneficioRecebido(BeneficiosPorFamiliaDto dto)
        {
            var beneficio = dto.CriarOuAlterarEntidade();
            beneficio.SetOpcaoBeneficio(Domain.Enums.TipoBeneficio.Recebe);
            if (beneficio.GetDataInicioBeneficiamento() == null)
            {
                beneficio.SetDataInicioBeneficiamento(DateTime.Now);
            }
            familiaRepositorio.AdicionarBeneficioRecebido(beneficio);

        }

        public void RemoverBeneficioDeInteresse(int familiaId, int beneficioId)
        {
            familiaRepositorio.RemoverBeneficioDeInteresse(familiaId, beneficioId);
        }
        public void RemoverBeneficioRecebido(int familiaId, int beneficioId)
        {
            familiaRepositorio.RemoverBeneficioRecebido(familiaId, beneficioId);
        }
        public void FinalizarBeneficioRecebido(int familiaId, int beneficioId, DateTime data)
        {
            familiaRepositorio.FinalizarBeneficioRecebido(familiaId, beneficioId, data);
        }
    }
}
