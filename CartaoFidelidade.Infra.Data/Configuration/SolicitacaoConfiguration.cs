using CartaoFidelidade.Domain.Solicitacoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CartaoFidelidade.Infra.Data.Configuration
{
    public class SolicitacaoConfiguration : IEntityTypeConfiguration<Solicitacao>
    {
        public void Configure(EntityTypeBuilder<Solicitacao> builder)
        {
            builder.ToTable("Solicitacoes");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.DataRequisicao).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.HasOne(s => s.Cliente)
                .WithMany(c => c.Solicitacoes)
                .HasForeignKey(s => s.ClienteId);
            builder.HasOne(s => s.Loja)
                .WithMany(l => l.Solicitacoes)
                .HasForeignKey(s => s.LojaId);
        }
    }
}
