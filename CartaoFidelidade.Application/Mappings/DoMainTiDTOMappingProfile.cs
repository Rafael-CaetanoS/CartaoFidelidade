using AutoMapper;
using CartaoFidelidade.Application.Clientes;
using CartaoFidelidade.Application.Cupons;
using CartaoFidelidade.Application.Lojas;
using CartaoFidelidade.Application.Solicitacoes;
using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Lojas;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Application.Mappings;

public class DoMainTiDTOMappingProfile : Profile
{
    public DoMainTiDTOMappingProfile()
    {
        CreateMap<Cliente, ClienteDTO>().ReverseMap();
        CreateMap<Loja, LojaDTO>().ReverseMap();
        CreateMap<Cupom, CupomDTO>().ReverseMap();
        CreateMap<Solicitacao, SolicitacaoDTO>().ReverseMap();
    }
}
