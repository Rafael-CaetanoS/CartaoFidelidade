using AutoMapper;
using CartaoFidelidade.Domain.Clientes;

namespace CartaoFidelidade.Application.Clientes;
public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;
    public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
    {
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }

    public async Task CreateCliente(ClienteDTO cliente)
    {
        var clienteEntity = _mapper.Map<Cliente>(cliente);
        await _clienteRepository.CreateCliente(clienteEntity);
    }

    public async Task<IEnumerable<ClienteDTO>> GetAllClientes()
    {
        var clientesEntity = await _clienteRepository.GetAllClientes();
        return _mapper.Map<IEnumerable<ClienteDTO>>(clientesEntity);
    }

    public async Task<ClienteDTO> GetClienteById(Guid id)
    {
       var clienteEntity = await _clienteRepository.GetClienteById(id); 
       return _mapper.Map<ClienteDTO>(clienteEntity);
    }

    public async Task UpdateCliente(ClienteDTO cliente)
    {
        throw new NotImplementedException();
    }
}
