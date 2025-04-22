using CartaoFidelidade.Domain.Cupons;

namespace CartaoFidelidade.Application.Cupons;

public interface ICupomService
{
    Task<IEnumerable<CupomDTO>> GetCuponsByClienteIdByLojaId(Guid clienteId, Guid lojaId);
    Task CreateCupomAsync(CupomDTO cupomDTO);
    Task UpdateCupomAsync(CupomDTO cupomDTO);
}
