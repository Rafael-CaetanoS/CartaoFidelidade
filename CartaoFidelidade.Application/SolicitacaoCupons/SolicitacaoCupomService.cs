
using CartaoFidelidade.Domain.SolicitacaoCupons;

namespace CartaoFidelidade.Application.SolicitacaoCupons;

public class SolicitacaoCupomService : ISolicitacaoCupomService
{
    private readonly ISolicitacaoCupomRespository _repository;

    public SolicitacaoCupomService(ISolicitacaoCupomRespository solicitacaoCupomRepository)
    {
     _repository = solicitacaoCupomRepository;   
    }

    public async Task createCupomSolicitacaoAsync(SolicitacaoCupom cupomSolicitacao)
    {
       await _repository.createCupomSolicitacaoAsync(cupomSolicitacao);
    }
}
