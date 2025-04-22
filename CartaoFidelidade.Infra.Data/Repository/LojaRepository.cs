using CartaoFidelidade.Domain.Lojas;
using CartaoFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CartaoFidelidade.Infra.Data.Repository;

public class LojaRepository : ILojaRepository
{
    private readonly ApplicationDbContext _context;

    public LojaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateLoja(Loja loja)
    {
        _context.Add(loja);
        await _context.SaveChangesAsync();
    }

    public async Task<Loja> GetLojaById(Guid id)
    {
        return await _context.Lojas.FindAsync(id);
    }

    public async Task<IEnumerable<Loja>> GetLojas()
    {
        return await _context.Lojas.ToListAsync();
    }

    public async Task UpdateLoja(Loja loja)
    {
        throw new NotImplementedException();
    }
}
