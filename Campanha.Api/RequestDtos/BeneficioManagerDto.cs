using System;

namespace Campanha.Api.RequestDtos
{
    public class BeneficioManagerDto
    {
        public int FamiliaId { get; set; }

        public int BeneficioId { get; set; }
    }

    public class FinalizarRecebimentoBeneficioDto : BeneficioManagerDto
    {
        public DateTime Data { get; set; }
    }
}
