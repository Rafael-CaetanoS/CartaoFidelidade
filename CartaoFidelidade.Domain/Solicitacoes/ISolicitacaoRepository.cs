namespace CartaoFidelidade.Domain.Solicitacoes;

public interface ISolicitacaoRepository
{
    Task<IEnumerable<Solicitacao>> GetSolicitacoesAsync();
    Task<Solicitacao> GetSolicitacaoByIdAsync(int id);
    Task CreateSolicitacao(Solicitacao solicitacao);
    Task UpdateSolicitacao(int solicitacaoId);
}
