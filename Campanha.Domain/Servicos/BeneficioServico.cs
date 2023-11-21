using Campanha.Domain.Dtos;
using Campanha.Domain.Entidades;
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
    public class BeneficioServico : EntidadeServicoPadrao<Beneficio, BeneficioDto> 
    {
        
        public BeneficioServico(IBeneficioRepositorio beneficioRepo) : base(beneficioRepo)
        { }


    }


}
