using CartaoFidelidade.Application.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace CartaoFidelidade.API.Controllers.Clientes;

[Route("api/[controller]")]
[ApiController]
public class ClienteController : ControllerBase
{
    IClienteService _clienteService;
    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetAll()
    {
        var clientes = await _clienteService.GetAllClientes();
        return Ok(clientes);
    }

    [HttpGet("{id:Guid}")]
    public async Task<ActionResult<ClienteDTO>> GetClienteByID([FromRoute] Guid id)
    {
        return await _clienteService.GetClienteById(id);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCliente([FromBody] ClienteDTO cliente)
    {
        await _clienteService.CreateCliente(cliente);
        return CreatedAtAction(nameof(GetClienteByID), new { id = cliente.Id }, cliente);
    }   
}
