using AutoMapper;
using CartaoFidelidade.Application.Cupons;
using CartaoFidelidade.Domain.Cupons;
using Moq;
namespace Spec.Application.Clientes;

public class CupomServiceSpec
{
    private readonly Mock<ICupomRepository> _cupomRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly CupomService _cupomService;
    public CupomServiceSpec()
    {
        _cupomRepositoryMock = new Mock<ICupomRepository>();
        _mapperMock = new Mock<IMapper>();
        _cupomService = new CupomService(_cupomRepositoryMock.Object, _mapperMock.Object);
    }

    [Fact]
    public async Task CreateCupom()
    {
        var cupomDTO = new CupomDTO();
        var cupom = new Cupom();
        _mapperMock.Setup(m => m.Map<Cupom>(It.IsAny<CupomDTO>())).Returns(cupom);
        _cupomRepositoryMock.Setup(r => r.CreateCupomAsync(cupom)).Returns(Task.CompletedTask);
        await _cupomService.CreateCupomAsync(cupomDTO);
        _mapperMock.Verify(m => m.Map<Cupom>(cupomDTO), Times.Once);
        _cupomRepositoryMock.Verify(r => r.CreateCupomAsync(cupom), Times.Once);
    }

    [Fact]
    public async Task GetCupons()
    {
        var clienteId = Guid.NewGuid();
        var lojaId = Guid.NewGuid();
        var cupons = new List<Cupom>
        {
            new Cupom { Id = 1, status = "Ativo", dataCriacao = DateTime.Now, lojaId = lojaId, clienteId = clienteId },
            new Cupom { Id = 2, status = "Inativo", dataCriacao = DateTime.Now, lojaId = lojaId, clienteId = clienteId },
        };
        _cupomRepositoryMock.Setup(r=> r.GetCuponsByClienteIdByLojaId(clienteId, lojaId)).ReturnsAsync(cupons);
        _mapperMock.Setup(m => m.Map<IEnumerable<CupomDTO>>(cupons)).Returns((cupons.Select(c => new CupomDTO
        {
            Id = c.Id,
            Status = c.status,
            dataCriacao = c.dataCriacao,
            lojaId = c.lojaId,
            clienteId = c.clienteId
        })));
        var result = await _cupomService.GetCuponsByClienteIdByLojaId(clienteId, lojaId);
        Assert.NotNull(cupons);
        Assert.Equal(result.Count(), cupons.Count);
        var firstCupom = result.First();
        Assert.Equal(firstCupom.Id, cupons[0].Id);
        Assert.Equal(firstCupom.clienteId, cupons[0].clienteId);
    }
    [Fact]
    public async Task GetCuponsEmpty()
    {
        var clienteId = Guid.NewGuid();
        var lojaId = Guid.NewGuid();
        _cupomRepositoryMock.Setup(r=> r.GetCuponsByClienteIdByLojaId(clienteId, lojaId)).ReturnsAsync([]);
        var result = await _cupomService.GetCuponsByClienteIdByLojaId(clienteId, lojaId);
        Assert.NotNull(result);
        Assert.Empty(result);
    }
}
