using CartaoFidelidade.Domain.Solicitacoes;
using CartaoFidelidade.Infra.Data.Context;

namespace CartaoFidelidade.Infra.Data.Repository;

public class SolicitacaoRepository : ISolicitacaoRepository
{
    private readonly ApplicationDbContext _context;
    public SolicitacaoRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task CreateSolicitacao(Guid clienteId, Guid lojaId)
    {
        throw new NotImplementedException();
    }

    public Task<Solicitacao> GetSolicitacaoByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Solicitacao>> GetSolicitacoesAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateSolicitacao(int solicitacaoId)
    {
        throw new NotImplementedException();
    }
}
