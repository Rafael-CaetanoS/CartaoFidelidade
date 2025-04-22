namespace CartaoFidelidade.Domain.Clientes;

public interface IClienteRepository
{
    Task<Cliente> GetClienteById(Guid id);
    Task<IEnumerable<Cliente>> GetAllClientes();
    Task CreateCliente(Cliente cliente);
    Task UpdateCliente(Cliente cliente);
}
