namespace CartaoFidelidade.Domain.Solicitacoes;

public interface ISolicitacaoRepository
{
    Task<IEnumerable<Solicitacao>> GetSolicitacoesAsync();
    Task<Solicitacao> GetSolicitacaoByIdAsync(int id);
    Task CreateSolicitacao(Guid clienteId, Guid lojaId);
    Task UpdateSolicitacao(int solicitacaoId);
}
