using Microsoft.EntityFrameworkCore;
using CartaoFidelidade.Domain.Clientes;
using CartaoFidelidade.Domain.Lojas;
using CartaoFidelidade.Domain.Cupons;
using CartaoFidelidade.Domain.Solicitacoes;

namespace CartaoFidelidade.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Loja> Lojas { get; set; }
    public DbSet<Cupom> Cupons { get; set; }
    public DbSet<Solicitacao> Solicitacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
