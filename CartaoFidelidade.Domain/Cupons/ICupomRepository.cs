using CartaoFidelidade.Domain.Clientes;

namespace CartaoFidelidade.Domain.Cupons;

public interface ICupomRepository
{
    Task<IEnumerable<Cupom>> GetCuponsByClienteIdByLojaId(Guid clienteId, Guid lojaId);
    Task CreateCupomAsync(Cupom cupom);
    Task UpdateCupomAsync(Cupom cupom);
}
