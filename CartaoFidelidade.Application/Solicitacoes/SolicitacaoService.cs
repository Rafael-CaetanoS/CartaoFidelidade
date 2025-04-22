using AutoMapper;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Solicitacoes;

public class SolicitacaoService : ISolicitacaoService
{
    private readonly ISolicitacaoRepository _solicitacaoRepository;
    private readonly IMapper _mapper;

    public SolicitacaoService(ISolicitacaoRepository solicitacaoRepository, IMapper mapper)
    {
        _solicitacaoRepository = solicitacaoRepository;
        _mapper = mapper;
    }

    public async Task CreateSolicitacao(SolicitacaoDTO solicitacaoDTO)
    {
       var solicitacaoEntity = _mapper.Map<Solicitacao>(solicitacaoDTO);
       await _solicitacaoRepository.CreateSolicitacao(solicitacaoEntity);
    }

    public async Task<SolicitacaoDTO> GetSolicitacaoByIdAsync(int id)
    {
       var solicitacaoEntity = await _solicitacaoRepository.GetSolicitacaoByIdAsync(id);
       return _mapper.Map<SolicitacaoDTO>(solicitacaoEntity);
    }

    public async Task<IEnumerable<SolicitacaoDTO>> GetSolicitacoesAsync()
    {
       var solicitacoesEntities = await _solicitacaoRepository.GetSolicitacoesAsync();
       return _mapper.Map<IEnumerable<SolicitacaoDTO>>(solicitacoesEntities);
    }

    public Task UpdateSolicitacao(int solicitacaoId)
    {
        throw new NotImplementedException();
    }
}
