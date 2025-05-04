using AutoMapper;
using CartaoFidelidade.Application.Cupons;
using CartaoFidelidade.Application.SolicitacaoCupons;
using CartaoFidelidade.Domain.SolicitacaoCupons;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Solicitacoes;

public class SolicitacaoService : ISolicitacaoService
{
    private readonly ISolicitacaoRepository _solicitacaoRepository;
    private readonly IMapper _mapper;
    private readonly ICupomService _cupomService;
    private readonly ISolicitacaoCupomService _SolicitacaoCupomService;
    public SolicitacaoService(ISolicitacaoRepository solicitacaoRepository, IMapper mapper, ICupomService cupomService)
    {
        _solicitacaoRepository = solicitacaoRepository;
        _mapper = mapper;
        _cupomService = cupomService;
    }

    public async Task CreateSolicitacao(SolicitacaoDTO solicitacaoDTO)
    {
        var quatindadeCupons = await _cupomService.GetCuponsByClienteIdByLojaId(solicitacaoDTO.ClienteId, solicitacaoDTO.LojaId);
        if(quatindadeCupons == null || quatindadeCupons.Count() < 10)
        {
            return;
        }
        var solicitacaoEntity = _mapper.Map<Solicitacao>(solicitacaoDTO);
        await _solicitacaoRepository.CreateSolicitacao(solicitacaoEntity);
        VincularCuponsHaSolicitacao(solicitacaoEntity.Id, quatindadeCupons);
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

    public void VincularCuponsHaSolicitacao(int solicitacaoId, IEnumerable<CupomDTO> cupons)
    {
        foreach (var cupom in cupons)
        {
            SolicitacaoCupom solicitacaoCupom = new SolicitacaoCupom(cupom.Id, solicitacaoId);
            _SolicitacaoCupomService.createCupomSolicitacaoAsync(solicitacaoCupom);
        }
    }
}
