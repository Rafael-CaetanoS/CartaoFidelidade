namespace CartaoFidelidade.Application.Clientes;

public interface IClienteService
{
    Task<ClienteDTO> GetClienteById(Guid id);
    Task<IEnumerable<ClienteDTO>> GetAllClientes();
    Task CreateCliente(ClienteDTO cliente);
    Task UpdateCliente(ClienteDTO cliente);
}
