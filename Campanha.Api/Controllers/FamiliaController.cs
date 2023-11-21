using Campanha.Api.RequestDtos;
using Campanha.Domain.Dtos;
using Campanha.Domain.Interfaces.IRepositorios;
using Campanha.Domain.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Campanha.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        public FamiliaServico Servico { get; set; }
        public FamiliaController(FamiliaServico servico)
        {
            Servico = servico;
        }
        [HttpGet("obter/{id}")]
        public IActionResult Obter(int id)
        {
            return Ok(Servico.ObterPorId(id));
        }
        [HttpGet("obter")]
        public IActionResult ObterLista()
        {
            return Ok(Servico.ObterLista(x => true));
        }

        [HttpPost("adicionar")]
        public IActionResult Adicionar([FromBody] FamiliaDto dto)
        {
            var sucesso = Servico.AdicionarRegistro(dto);

            return Ok(sucesso);
        }

        [HttpPut("editar")]
        public IActionResult Editar([FromBody] FamiliaDto dto)
        {
            var sucesso = Servico.EditarRegistro(dto);
            return Ok(sucesso);
        }

        [HttpDelete("excluir/{id}")]
        public IActionResult Remover(int id)
        {
            var sucesso = Servico.ExcluirRegistro(id);
            return Ok(sucesso);
        }

        [HttpPost("add_beneficio_interesse")]
        public IActionResult AdicionarBeneficioInteresse([FromBody]BeneficiosPorFamiliaDto dto)
        {
            Servico.AdicionarBeneficioDeInteresse(dto);
            return Ok();
        }
        
        [HttpPost("add_beneficio_recebido")]
        public IActionResult AdicionarBeneficioRecebido([FromBody] BeneficiosPorFamiliaDto dto)
        {
            Servico.AdicionarBeneficioRecebido(dto);
            return Ok();
        }

        [HttpPost("remover_beneficio_interesse")]
        public IActionResult RemoverBeneficioInteresse([FromBody] BeneficioManagerDto dto)
        {
            Servico.RemoverBeneficioDeInteresse(dto.FamiliaId, dto.BeneficioId);
            return Ok();
        }

        [HttpPost("remover_beneficio_recebido")]
        public IActionResult RemoverBeneficioRecebido([FromBody] BeneficioManagerDto dto)
        {
            Servico.RemoverBeneficioRecebido(dto.FamiliaId, dto.BeneficioId);
            return Ok();
        }

        [HttpPost("finalizar_recebimento_beneficio")]
        public IActionResult FinalizarBeneficio([FromBody] BeneficioManagerDto dto)
        {
            Servico.RemoverBeneficioRecebido(dto.FamiliaId, dto.BeneficioId);
            return Ok();
        }


    }
}
