using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Solicitacoes;

public interface ISolicitacaoService
{
    Task<IEnumerable<Solicitacao>> GetSolicitacoesAsync();
    Task<Solicitacao> GetSolicitacaoByIdAsync(int id);
    Task CreateSolicitacao(Guid clienteId, Guid lojaId);
    Task UpdateSolicitacao(int solicitacaoId);
}
