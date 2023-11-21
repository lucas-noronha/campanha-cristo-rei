using Campanha.Data.ConfiguracoesEntidades;
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
    public class FamiliaRepositorio : RepositorioPadrao<Familia>, IFamiliaRepositorio
    {
        private readonly CampanhasDb Db;
        public FamiliaRepositorio(CampanhasDb db) : base(db)
        {
            Db = db;
        }

        public void AdicionarBeneficioDeInteresse(BeneficioxFamilia beneficio)
        {
            Db.Set<BeneficioxFamilia>().Add(beneficio);
            Db.SaveChanges();
        }

        public void AdicionarBeneficioRecebido(BeneficioxFamilia beneficio)
        {
            Db.Set<BeneficioxFamilia>().Add(beneficio);
            Db.SaveChanges();
        }

        public override Familia BuscarPorId(int id)
        {
            Familia familia = Db.Familias.Include(Familia.GetNameOfCampanha()).Include(Familia.GetNameOfBeneficios()).FirstOrDefault(x => x.GetId() == id);
            return familia;
        }
        public void FinalizarBeneficioRecebido(int familiaId, int beneficioId, DateTime data)
        {
            Familia familia = BuscarPorId(familiaId);
            if (familia.GetBeneficiosRecebidos().Any())
            {
                var beneficio = familia.GetBeneficiosRecebidos().FirstOrDefault(x => x.GetBeneficioId() == beneficioId);
                beneficio.SetDataFinalizacaoBeneficiamento(data);
                Db.Set<BeneficioxFamilia>().Entry(beneficio).State = EntityState.Modified;
                Db.SaveChanges();
            }
        }

        public void RemoverBeneficioDeInteresse(int familiaId, int beneficioId)
        {
            var dbSet = Db.Set<BeneficioxFamilia>();
            var beneficio = dbSet.FirstOrDefault(x => x.GetFamiliaId() == familiaId && x.GetBeneficioId() == beneficioId && x.GetOpcaoBeneficio() == Domain.Enums.TipoBeneficio.TemInteresse);
            if (beneficio != null)
            {
                dbSet.Remove(beneficio);
                Db.SaveChanges();
            }

        }

        public void RemoverBeneficioRecebido(int familiaId, int beneficioId)
        {
            var dbSet = Db.Set<BeneficioxFamilia>();
            var beneficio = dbSet.FirstOrDefault(x => x.GetFamiliaId() == familiaId && x.GetBeneficioId() == beneficioId && x.GetOpcaoBeneficio() == Domain.Enums.TipoBeneficio.Recebe);
            if (beneficio != null)
            {
                dbSet.Remove(beneficio);
                Db.SaveChanges();
            }
        }
    }
}
