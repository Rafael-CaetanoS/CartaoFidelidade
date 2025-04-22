using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CartaoFidelidade.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Infra.Data.Repository;
using CartaoFidelidade.Application.Clientes;
using CartaoFidelidade.Application.Mappings;
using CartaoFidelidade.Domain.Lojas;
using CartaoFidelidade.Application.Lojas;
using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Solicitacoes;
using CartaoFidelidade.Application.Cupons;

namespace CartaoFidelidade.Infra.IoC;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            ));
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<ILojaRepository, LojaRepository>();
        services.AddScoped<ILojaService, LojaService>();
        services.AddScoped<ICupomRepository, CupomRepository>();
        services.AddScoped<ICupomService, CupomService>();
        services.AddScoped<ISolicitacaoRepository, SolicitacaoRepository>();
        services.AddAutoMapper(typeof(DoMainTiDTOMappingProfile));
        return services;
    }
}
