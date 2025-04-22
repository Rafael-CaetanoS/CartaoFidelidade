using CartaoFidelidade.Application.Lojas;
using Microsoft.AspNetCore.Mvc;

namespace CartaoFidelidade.API.Controllers.Lojas;

[Route("api/[controller]")]
[ApiController]
public class LojaController : ControllerBase
{
    private readonly ILojaService _lojaService;

    public LojaController(ILojaService lojaService)
    {
        _lojaService = lojaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LojaDTO>>> GetAllLojas()
    {
        var lojas = await _lojaService.GetLojas();
        return Ok(lojas);
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<LojaDTO>> GetLojaById([FromRoute] Guid id)
    {
        var loja = await _lojaService.GetLojaById(id);
        return Ok(loja);
    }

    [HttpPost]
    public async Task<ActionResult> CreateLoja([FromBody] LojaDTO loja)
    {
        if (loja == null)
        {
            return BadRequest("Loja não pode ser nula.");
        }
        await _lojaService.CreateLoja(loja);
        return CreatedAtAction(nameof(GetLojaById), new { id = loja.Id }, loja);
    }   
}