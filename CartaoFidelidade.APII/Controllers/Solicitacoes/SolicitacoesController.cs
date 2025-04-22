using CartaoFidelidade.Application.Solicitacoes;
using Microsoft.AspNetCore.Mvc;

namespace CartaoFidelidade.APII.Controllers.Solicitacoes;

[ApiController]
[Route("api/[controller]")]
public class SolicitacoesController : ControllerBase
{
    private readonly ISolicitacaoService _solicitacaoService;
    public SolicitacoesController(ISolicitacaoService solicitacaoService)
    {
        _solicitacaoService = solicitacaoService;
    }

    [HttpGet]    
    public async Task<ActionResult<IEnumerable<SolicitacaoDTO>>> GetAllSolicitacoes()
    {
        var solicitacoes = await _solicitacaoService.GetSolicitacoesAsync();
        return Ok(solicitacoes);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SolicitacaoDTO>> GetSolicitacaoById(int id)
    {
        var solicitacao = await _solicitacaoService.GetSolicitacaoByIdAsync(id);
        if (solicitacao == null)
        {
            return NotFound();
        }
        return Ok(solicitacao);
    }

    [HttpPost]
    public async Task<ActionResult> CreateSolicitacao([FromBody] SolicitacaoDTO solicitacaoDTO)
    {
        if (solicitacaoDTO == null)
        {
            return BadRequest("Solicitação não pode ser nula.");
        }

        await _solicitacaoService.CreateSolicitacao(solicitacaoDTO);
        return CreatedAtAction(nameof(GetSolicitacaoById), new { id = solicitacaoDTO.Id }, solicitacaoDTO);
    }
}
