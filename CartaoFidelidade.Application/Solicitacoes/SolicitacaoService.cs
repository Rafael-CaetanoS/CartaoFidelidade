using AutoMapper;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Solicitacoes;

public class SolicitacaoService : ISolicitacaoService
{
    private readonly ISolicitacaoRepository _solicitacaoRepository;
    private readonly IMapper _mapper;
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
