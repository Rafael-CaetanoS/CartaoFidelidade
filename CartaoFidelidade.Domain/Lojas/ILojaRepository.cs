namespace CartaoFidelidade.Domain.Lojas;

public interface ILojaRepository
{
    Task<IEnumerable<Loja>> GetLojas();
    Task<Loja> GetLojaById(Guid id);
    Task CreateLoja(Loja loja);
    Task UpdateLoja(Loja loja);
}
