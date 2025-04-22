using AutoMapper;
using CartaoFidelidade.Domain.Cupons;

namespace CartaoFidelidade.Application.Cupons;

public class CupomService : ICupomService
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IMapper _mapper;

    public CupomService(ICupomRepository cupomRepository, IMapper mapper)
    {
        _cupomRepository = cupomRepository;
        _mapper = mapper;
    }

    public async Task CreateCupomAsync(CupomDTO cupomDTO)
    {
        var cuporEntity = _mapper.Map<Cupom>(cupomDTO);
        await _cupomRepository.CreateCupomAsync(cuporEntity);
    }

    public async Task<IEnumerable<CupomDTO>> GetCuponsByClienteIdByLojaId(Guid clienteId, Guid lojaId)
    {
       var cupons = await _cupomRepository.GetCuponsByClienteIdByLojaId(clienteId, lojaId);
       return _mapper.Map<IEnumerable<CupomDTO>>(cupons);
    }

    public async Task UpdateCupomAsync(CupomDTO cupomDTO)
    {
        throw new NotImplementedException();
    }
}
