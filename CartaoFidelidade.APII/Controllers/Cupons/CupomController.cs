using CartaoFidelidade.Application.Cupons;
using Microsoft.AspNetCore.Mvc;

namespace CartaoFidelidade.API.Controllers.Cupons;

[Route("api/[controller]")]
[ApiController]
public class CupomController : ControllerBase
{
    private readonly ICupomService _cupomService;
    public CupomController(ICupomService cupomService)
    {
        _cupomService = cupomService;
    }
    [HttpGet("{clienteId:Guid}/{lojaId:Guid}")]
    public async Task<ActionResult<IEnumerable<CupomDTO>>> GetAllCuponsByClienteIdByLojaId(
        [FromRoute] Guid clienteId, [FromRoute] Guid lojaId)
    {
        var cupons = await _cupomService.GetCuponsByClienteIdByLojaId(clienteId, lojaId);
        return Ok(cupons);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCupom([FromBody] CupomDTO cupom)
    {
        await _cupomService.CreateCupomAsync(cupom);
        return CreatedAtAction(nameof(GetAllCuponsByClienteIdByLojaId), new { clienteId = cupom.clienteId, lojaId = cupom.lojaId }, cupom);
    }
}
