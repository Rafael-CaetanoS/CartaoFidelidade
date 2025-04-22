using CartaoFidelidade.Domain.Lojas;

namespace CartaoFidelidade.Application.Lojas;
public interface ILojaService
{
    Task<IEnumerable<LojaDTO>> GetLojas();
    Task<LojaDTO> GetLojaById(Guid id);
    Task CreateLoja(LojaDTO loja);
    Task UpdateLoja(LojaDTO loja);
}
