using CartaoFidelidade.Domain.Solicitacoes;
using CartaoFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CartaoFidelidade.Infra.Data.Repository;

public class SolicitacaoRepository : ISolicitacaoRepository
{
    private readonly ApplicationDbContext _context;
    public SolicitacaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task CreateSolicitacao(Solicitacao solicitacao)
    {
        _context.Add(solicitacao);
        await _context.SaveChangesAsync();
    }

    public async Task<Solicitacao> GetSolicitacaoByIdAsync(int id)
    {
        return await _context.Solicitacoes.FindAsync(id);
    }

    public async Task<IEnumerable<Solicitacao>> GetSolicitacoesAsync()
    {
        return await _context.Solicitacoes.ToListAsync();
    }

    public Task UpdateSolicitacao(int solicitacaoId)
    {
        throw new NotImplementedException();
    }
}
