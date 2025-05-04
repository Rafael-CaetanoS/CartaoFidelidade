using CartaoFidelidade.Domain.SolicitacaoCupons;

namespace CartaoFidelidade.Application.SolicitacaoCupons;

public interface ISolicitacaoCupomService
{
    public Task createCupomSolicitacaoAsync(SolicitacaoCupom cupomSolicitacao);
}
