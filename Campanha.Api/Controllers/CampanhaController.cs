using Campanha.Domain.Dtos;
using Campanha.Domain.Interfaces.IRepositorios;
using Campanha.Domain.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Campanha.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampanhaController : ControllerBase
    {
        public CampanhaServico Servico { get; set; }
        public CampanhaController(CampanhaServico servico)
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
        public IActionResult Adicionar([FromBody] CampanhaDto dto)
        {
            var sucesso = Servico.AdicionarRegistro(dto);

            return Ok(sucesso);
        }

        [HttpPut("editar")]
        public IActionResult Editar([FromBody] CampanhaDto dto)
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


    }
}
