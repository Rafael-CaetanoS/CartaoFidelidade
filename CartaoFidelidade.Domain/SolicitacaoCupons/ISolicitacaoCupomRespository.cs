namespace CartaoFidelidade.Domain.SolicitacaoCupons;

public interface ISolicitacaoCupomRespository
{
    public Task createCupomSolicitacaoAsync(SolicitacaoCupom cupomSolicitacao);
}
