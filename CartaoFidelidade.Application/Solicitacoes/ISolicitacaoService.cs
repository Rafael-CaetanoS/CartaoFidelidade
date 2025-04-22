using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Solicitacoes;

public interface ISolicitacaoService
{
    Task<IEnumerable<SolicitacaoDTO>> GetSolicitacoesAsync();
    Task<SolicitacaoDTO> GetSolicitacaoByIdAsync(int id);
    Task CreateSolicitacao(SolicitacaoDTO solicitacaoDTO);
    Task UpdateSolicitacao(int solicitacaoId);
}
