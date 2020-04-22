using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.Entities;

namespace QuickBuy.Repository.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pd => pd.Id);

            builder.Property(pd => pd.DataPedido)
                .IsRequired();
            builder.Property(pd => pd.FormaPagamentoId)
                .IsRequired();
            builder.Property(pd => pd.CEP)
                .IsRequired()
                .HasMaxLength(8);
            builder.Property(pd => pd.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(pd => pd.NumeroEndereco)
                .IsRequired();
            builder.Property(pd => pd.Cidade)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(pd => pd.Estado)
                .IsRequired()
                .HasMaxLength(2);
        }
    }
}
