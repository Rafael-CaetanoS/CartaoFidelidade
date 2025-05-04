using CartaoFidelidade.Domain;
using CartaoFidelidade.Domain.SolicitacaoCupons;
using CartaoFidelidade.Infra.Data.Context;

namespace CartaoFidelidade.Infra.Data.Repository;

public class SolicitacaoCupomRepository : ISolicitacaoCupomRespository
{
    private readonly ApplicationDbContext _context;

    public SolicitacaoCupomRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task createCupomSolicitacaoAsync(SolicitacaoCupom cupomSolicitacao)
    {
        _context.Add(cupomSolicitacao);
        await _context.SaveChangesAsync();
    }
}
