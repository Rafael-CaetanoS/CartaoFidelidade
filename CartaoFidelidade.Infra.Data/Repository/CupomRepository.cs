using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CartaoFidelidade.Infra.Data.Repository;

public class CupomRepository : ICupomRepository
{
    private readonly ApplicationDbContext _context;
    public CupomRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task CreateCupomAsync(Cupom cupom)
    {
        _context.Add(cupom);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Cupom>> GetCuponsByClienteIdByLojaId(Guid clienteId, Guid lojaId)
    {
        return await _context.Cupons.Where(c => c.cliente.Id == clienteId && c.loja.Id == lojaId).ToListAsync();
    }

    public async Task UpdateCupomAsync(Cupom cupom)
    {
        _context.Update(cupom);
        await _context.SaveChangesAsync();
    }
}
