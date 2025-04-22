using AutoMapper;
using CartaoFidelidade.Domain.Lojas;

namespace CartaoFidelidade.Application.Lojas;

public class LojaService : ILojaService
{
    private readonly ILojaRepository _lojaRepository;
    private readonly IMapper _mapper;
    public LojaService(ILojaRepository lojaRepository, IMapper mapper)
    {
        _lojaRepository = lojaRepository;
        _mapper = mapper;
    }

    public async Task CreateLoja(LojaDTO loja)
    {
        var LojaEntity = _mapper.Map<Loja>(loja);
        await _lojaRepository.CreateLoja(LojaEntity);
    }

    public async Task<LojaDTO> GetLojaById(Guid id)
    {
        var lojaEntity = await _lojaRepository.GetLojaById(id);
        return _mapper.Map<LojaDTO>(lojaEntity);
    }

    public async Task<IEnumerable<LojaDTO>> GetLojas()
    {
        var lojasEntity = await _lojaRepository.GetLojas();
        return _mapper.Map<IEnumerable<LojaDTO>>(lojasEntity);
    }

    public async Task UpdateLoja(LojaDTO loja)
    {
        throw new NotImplementedException();
    }
}

