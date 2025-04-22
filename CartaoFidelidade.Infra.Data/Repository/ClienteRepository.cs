using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CartaoFidelidade.Infra.Data.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly ApplicationDbContext _context;

    public ClienteRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateCliente(Cliente cliente)
    {
        _context.Add(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Cliente>> GetAllClientes()
    {
        return await _context.Clientes.ToListAsync();
    }

    public async Task<Cliente> GetClienteById(Guid id)
    {
        return await _context.Clientes.FindAsync(id);
    }

    public async Task UpdateCliente(Cliente cliente)
    {
        _context.Update(cliente);
        await _context.SaveChangesAsync();
    }
}
