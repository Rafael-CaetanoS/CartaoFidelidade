using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Infra.Data.Context;
using CartaoFidelidade.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Spec.Infra;
public class CupomRepositorySpec
{
    private readonly Mock<ApplicationDbContext> _dbContext;
    private CupomRepository _cupomRepository;

    public CupomRepositorySpec()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "CupomDatabase")
            .Options;
        _dbContext = new Mock<ApplicationDbContext>(options);
        _cupomRepository = new CupomRepository(_dbContext.Object);
    }

    [Fact]
    public async Task CreateCupomRepositoryResult()
    {
        var cupom = new Cupom{
            Id = 1,
            status = "teste",
            dataCriacao = DateTime.Now,
            lojaId = Guid.NewGuid(),
            clienteId = Guid.NewGuid(),
        };
        _dbContext.Setup(c => c.Add(It.IsAny<Cupom>()));
        _dbContext.Setup(c => c.SaveChangesAsync(default)).ReturnsAsync(1);
        await _cupomRepository.CreateCupomAsync(cupom);
        _dbContext.Verify(c => c.Add(It.Is<Cupom>(c => c.Id == cupom.Id)), Times.Once);
        _dbContext.Verify(c => c.SaveChangesAsync(default), Times.Once);
    }
}